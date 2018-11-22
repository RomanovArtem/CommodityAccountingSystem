using CommodityAccountingSystem.View.DataView;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.View
{
    public class DataViewModel 
    {
        #region Fields
        private IMainWindows _mainWindow;

        private IDataView _dataView;

        /// <summary>
        /// Переход к товарам
        /// </summary>
        private RelayCommand _loadProductsViewCommand;

        /// <summary>
        /// переход к категориям
        /// </summary>
        private RelayCommand _loadCategoriesViewCommand;

        /// <summary>
        /// переход к истории продаж
        /// </summary>
        private RelayCommand _loadHistorySalesComand;

        #endregion

        #region Constructors
        public DataViewModel(IMainWindows mainWindows)
        {
            _mainWindow = mainWindows ?? throw new ArgumentNullException(nameof(mainWindows));
        }

        public DataViewModel(IDataView dataView)
        {
            _dataView = dataView ?? throw new ArgumentNullException(nameof(dataView));
        }

        public DataViewModel()
        {
        }
        #endregion

        #region Properties
        public IDataView DataView { get; set; }
        #endregion

        #region Commands
        public RelayCommand LoadProductsComand
        {
            get
            {
                return _loadProductsViewCommand = _loadProductsViewCommand ??
                  new RelayCommand(OnLoadProductsView, CanLoadProductsView);
            }
        }

        public RelayCommand LoadCategoriesComand
        {
            get
            {
                return _loadCategoriesViewCommand = _loadCategoriesViewCommand ??
                  new RelayCommand(OnLoadCategoriesView, CanLoadCategoriesView);
            }
        }

        public RelayCommand LoadHistorySalesComand
        {
            get
            {
                return _loadHistorySalesComand = _loadHistorySalesComand ??
                  new RelayCommand(OnLoadHistorySalesView, CanLoadHistorySalesView);
            }
        }
        
        #endregion

        #region Methods

        private bool CanLoadProductsView()
        {
            return true;
        }
        private void OnLoadProductsView()
        {
            _dataView.LoadView(View.DataView.ViewType.Products);
        }
        private bool CanLoadCategoriesView()
        {
            return true;
        }
        private void OnLoadCategoriesView()
        {
            _dataView.LoadView(View.DataView.ViewType.Categories);
        }

        private bool CanLoadHistorySalesView()
        {
            return true;
        }
        private void OnLoadHistorySalesView()
        {
            _dataView.LoadView(View.DataView.ViewType.HistorySales);
        }

        #endregion
    }
}