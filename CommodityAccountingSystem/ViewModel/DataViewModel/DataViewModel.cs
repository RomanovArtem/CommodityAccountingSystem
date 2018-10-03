using CommodityAccountingSystem.View.DataView;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.View
{
    public class DataViewModel : INotifyPropertyChanged
    {
        #region Fields
        private IMainWindows _mainWindow;

        private IDataView _dataView;

        /// <summary>
        /// Переход к товарам
        /// </summary>
        private RelayCommand _LoadProductsViewCommand;

        /// <summary>
        /// переход к категориям
        /// </summary>
        private RelayCommand _LoadCategoriesViewCommand;

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
                return _LoadProductsViewCommand = _LoadProductsViewCommand ??
                  new RelayCommand(OnLoadProductsView, CanLoadProductsView);
            }
        }

        public RelayCommand LoadCategoriesComand
        {
            get
            {
                return _LoadCategoriesViewCommand = _LoadCategoriesViewCommand ??
                  new RelayCommand(OnLoadCategoriesView, CanLoadCategoriesView);
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

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}