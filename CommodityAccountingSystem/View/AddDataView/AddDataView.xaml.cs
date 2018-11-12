using CommodityAccountingSystem.ViewModel.AddDataViewModel;
using System.Windows;
using System.Windows.Controls;

namespace CommodityAccountingSystem.View.AddDataView
{
    /// <summary>
    /// Логика взаимодействия для AddDataView.xaml
    /// </summary>
    public interface IAddDataView
    {
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
        AddProducts,
        AddCategories,
        AddHistorySales,
    }


    /// <summary>
    /// Interaction logic for FirstUC.xaml
    /// </summary>
    public partial class AddDataView : UserControl, IAddDataView
    {
        public AddDataView()
        {
            InitializeComponent();
            this.Loaded += AddDataWindow_Loaded;
        }

        private void AddDataWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //загрузка вьюмодел для кнопок меню
            AddDataViewModel vm = new AddDataViewModel(this);
            //даем доступ к этому кодбихайнд
            vm.AddDataView = this;
            //делаем эту вьюмодел контекстом данных
            this.DataContext = vm;

            LoadView(ViewType.AddProducts);
        }

        public void LoadView(ViewType typeView)
        {
            switch (typeView)
            {
                case ViewType.AddProducts:
                    AddProductView viewAddProduct = new AddProductView();
                    AddProductViewModel viewModelAddProduct = new AddProductViewModel(this);
                    viewAddProduct.DataContext = viewModelAddProduct;
                    this.OutputView.Content = viewAddProduct;
                    break;

                case ViewType.AddCategories:
                    AddCategoriesView viewAddCategories = new AddCategoriesView();
                    AddCategoriesViewModel viewModelAddCategories = new AddCategoriesViewModel(this);
                    viewAddCategories.DataContext = viewModelAddCategories;
                    this.OutputView.Content = viewAddCategories;
                    break;

                case ViewType.AddHistorySales:
                    AddHistorySalesView viewAddHistorySales = new AddHistorySalesView();
                    AddHistorySalesViewModel viewModelHistorySales = new AddHistorySalesViewModel(this);
                    viewAddHistorySales.DataContext = viewModelHistorySales;
                    this.OutputView.Content = viewAddHistorySales;
                    break;
            }
        }
    }
}
