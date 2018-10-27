using CommodityAccountingSystem.View;
using CommodityAccountingSystem.View.DataView;
using CommodityAccountingSystem.ViewModel;
using CommodityAccountingSystem.ViewModel.AddDataViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommodityAccountingSystem.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public interface IMainWindows
    {
        /// <summary>
        /// Показ сообщения для пользователя
        /// </summary>
        /// <param name="message">текст сообщения</param>
        void ShowMessage(string message);

        /// <summary>
        /// Загрузка нужной View
        /// </summary>
        /// <param name="view">экземпляр UserControl</param>
        void LoadView(ViewType typeView);
    }

    /// <summary>
    /// Типы вьюшек для загрузки
    /// </summary>
    public enum ViewType
    {
        Main,
        First,
        DataView
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindows
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //загрузка вьюмодел для кнопок меню
            MenuViewModel vm = new MenuViewModel();
            //даем доступ к этому кодбихайнд
            vm.MainWindows = this;
            //делаем эту вьюмодел контекстом данных
            this.DataContext = vm;

            //загрузка стартовой View
            LoadView(ViewType.Main);
        }


        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.Main:
                    //загружаем вьюшку, ее вьюмодель
                    MainUC view = new MainUC();
                    MainViewModel vm = new MainViewModel(this);
                    //связываем их м/собой
                    view.DataContext = vm;
                    //отображаем
                    this.OutputView.Content = view;
                    break;
                case ViewType.First:
                    AddDataView.AddDataView viewF = new AddDataView.AddDataView();
                    AddDataViewModel vmF = new AddDataViewModel(this);
                    viewF.DataContext = vmF;
                    this.OutputView.Content = viewF;
                    break;
                case ViewType.DataView:
                    DataView.DataView viewS = new DataView.DataView();
                    DataViewModel vmS = new DataViewModel(this);
                    viewS.DataContext = vmS;
                    this.OutputView.Content = viewS;
                    break;
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}