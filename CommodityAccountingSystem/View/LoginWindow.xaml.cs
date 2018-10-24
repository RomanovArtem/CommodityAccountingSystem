using CommodityAccountingSystem.ViewModel;
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
using System.Windows.Shapes;

namespace CommodityAccountingSystem.View
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public interface ILoginWindows
    {
        void CloseWindow();

    }


    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window, ILoginWindows
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        public void CloseWindow()
        {
            this.Close();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //загрузка вьюмодел для кнопок меню
            LoginViewModel vm = new LoginViewModel();
            //даем доступ к этому кодбихайнд
            vm.LoginWindows = this;
            //делаем эту вьюмодел контекстом данных
            this.DataContext = vm;
        }
    }
}
