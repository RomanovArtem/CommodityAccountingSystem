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
        /// Переход к первой вьюшке
        /// </summary>
        private RelayCommand _LoadProductsViewCommand;

        private RelayCommand _LoadCategoriesViewCommand;


        /// <summary>
        /// Список продуктов для ComboBox
        /// </summary>
        private List<Models.Product> productsList;

        /// <summary>
        /// Сообщение пользователю
        /// </summary>
        private RelayCommand _showMessageCommand;

        /// <summary>
        /// Выбранное число в списке чисел
        /// </summary>
        private string _selectedNumber;

        /// <summary>
        /// Сервисы
        /// </summary>
        private Service _service;

        #endregion

        #region Constructors
        public DataViewModel(IMainWindows mainWindows)
        {
            _mainWindow = mainWindows ?? throw new ArgumentNullException(nameof(mainWindows));

            _service = new Service();

            productsList = _service.GetProducts().ToList();
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


        public List<Models.Product> ProductsList
        {
            get { return productsList; }
            set
            {
                productsList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ProductsList)));
            }
        }

        public string SelectedNumber
        {
            get { return _selectedNumber; }
            set
            {
                _selectedNumber = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedNumber)));
            }
        }
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

        public RelayCommand ShowMessageCommand
        {
            get
            {
                return _showMessageCommand = _showMessageCommand ??
                  new RelayCommand(OnShowMessage, CanShowMessage);
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

        private bool CanShowMessage()
        {
            return true;
        }

        private void OnShowMessage()
        {
            _mainWindow.ShowMessage($"Вы выбрали: {SelectedNumber}");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}