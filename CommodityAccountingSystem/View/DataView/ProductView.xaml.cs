using System.Windows;
using System.Windows.Controls;
using CommodityAccountingSystem.View.EditDataView;
using CommodityAccountingSystem.ViewModel.EditDataViewModel;
using Models;

namespace CommodityAccountingSystem.View.DataView
{
    /// <summary>
    /// Логика взаимодействия для ProductView.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void UpdateProduct(object sender, RoutedEventArgs e)
        {
            var cell = sender as DataGridCell;

            var view = new EditProductWindow
            {
                DataContext = new EditProductViewModel(cell.DataContext as Product)
            };

            view.ShowDialog();

        }

       
    }
}
