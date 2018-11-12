using CommodityAccountingSystem.View;
using CommodityAccountingSystem.View.AddDataView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityAccountingSystem.ViewModel.AddDataViewModel
{
    public class AddDataViewModel
    {
        private IAddDataView _addDataView;
        private IMainWindows _mainWindow;

        private RelayCommand _loadAddProductComand;
        private RelayCommand _loadAddHistorySalesComand;

        private RelayCommand _loadAddCategoriesComand;



        #region Properties
        public IAddDataView AddDataView { get; set; }
        #endregion

        public AddDataViewModel(IAddDataView addDataView)
        {
            _addDataView = addDataView;
        }

        public AddDataViewModel(IMainWindows mainWindows)
        {
            _mainWindow = mainWindows;
        }


        #region Commands
        public RelayCommand LoadAddProductComand
        {
            get
            {
                return _loadAddProductComand = _loadAddProductComand ??
                  new RelayCommand(OnLoadProductsView, CanLoadHistorySalesView);
            }
        }

        public RelayCommand LoadAddCategoriesComand
        {
            get
            {
                return _loadAddCategoriesComand = _loadAddCategoriesComand ??
                  new RelayCommand(OnLoadCategoriesView, CanLoadHistorySalesView);
            }
        }

        public RelayCommand LoadAddHistorySalesComand
        {
            get
            {
                return _loadAddHistorySalesComand = _loadAddHistorySalesComand ??
                  new RelayCommand(OnLoadHistorySalesView, CanLoadHistorySalesView);
            }
        }

        private void OnLoadProductsView()
        {
            _addDataView.LoadView(View.AddDataView.ViewType.AddProducts);
        }

        private void OnLoadCategoriesView()
        {
            _addDataView.LoadView(View.AddDataView.ViewType.AddCategories);
        }

        private void OnLoadHistorySalesView()
        {
            _addDataView.LoadView(View.AddDataView.ViewType.AddHistorySales);
        }

        private bool CanLoadHistorySalesView()
        {
            return true;
        }

        #endregion

    }
}
