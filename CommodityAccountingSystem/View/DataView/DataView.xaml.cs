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
        Products,
        Categories,
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
            DataViewModel vm = new DataViewModel(this);
            //даем доступ к этому кодбихайнд
            vm.DataView = this;
            //делаем эту вьюмодел контекстом данных
            this.DataContext = vm;

            // DataViewModel viewModelData = new DataViewModel(this);

            //загрузка стартовой View
            LoadView(ViewType.Products);
        }

        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.Products:
                    //загружаем вьюшку, ее вьюмодель
                    ProductView viewProduct = new ProductView();
                    ProductViewModel viewModelProducts = new ProductViewModel(this);
                    //связываем их м/собой
                    viewProduct.DataContext = viewModelProducts;
                    //отображаем
                    this.OutputView.Content = viewProduct;
                    break;

                case ViewType.Categories:
                    //загружаем вьюшку, ее вьюмодель
                    CategoryView viewCategories = new CategoryView();
                    CategoryViewModel viewModelCategories = new CategoryViewModel(this);
                    //связываем их м/собой
                    viewCategories.DataContext = viewModelCategories;
                    //отображаем
                    this.OutputView.Content = viewCategories;
                    break;
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
