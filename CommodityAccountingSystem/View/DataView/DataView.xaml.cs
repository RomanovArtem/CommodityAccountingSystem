using CommodityAccountingSystem.ViewModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace CommodityAccountingSystem.View.DataView
{

    /// <summary>
    /// Логика взаимодействия для DataView.xaml
    /// </summary>
    public interface IDataView
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
        Product
    }

    /// <summary>
    /// Interaction logic for DataView.xaml
    /// </summary>
    public partial class DataView : UserControl, IDataView
    {
        public DataView()
        {
            InitializeComponent();
            this.Loaded += DataWindow_Loaded;

        }

        private void DataWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //загрузка вьюмодел для кнопок меню
            DataViewModel vm = new DataViewModel();
            //даем доступ к этому кодбихайнд
            vm.DataView = this;
            //делаем эту вьюмодел контекстом данных
            this.DataContext = vm;

            //загрузка стартовой View
            LoadView(ViewType.Product);
        }

        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.Product:
                    //загружаем вьюшку, ее вьюмодель
                    ProductView view = new ProductView();
                    ProductViewModel vm = new ProductViewModel(this);
                    //связываем их м/собой
                    view.DataContext = vm;
                    //отображаем
                    this.OutputView.Content = view;
                    break;
            }
        }

        public void ShowMessage(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}
