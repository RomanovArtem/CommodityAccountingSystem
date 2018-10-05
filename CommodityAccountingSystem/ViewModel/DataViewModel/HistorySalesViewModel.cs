using CommodityAccountingSystem.View;
using CommodityAccountingSystem.View.DataView;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.ViewModel.DataViewModel
{
    public class HistorySalesViewModel : INotifyPropertyChanged
    {
        #region Fields
        private IDataView _dataView;

        /// <summary>
        /// Список названий категорий 
        /// </summary>
        private List<string> _categoriesTitleList;

        /// <summary>
        /// Список продуктов
        /// </summary>
        private List<Models.Product> _productsList;

        /// <summary>
        /// Выбранная категория
        /// </summary>
        public string _selectedCategory;

        /// <summary>
        /// Сообщение пользователю
        /// </summary>
        private RelayCommand _ShowMessageCommand;

        /// <summary>
        /// Сервисы
        /// </summary>
        private Service _service;
        #endregion

        #region Constructors
        public HistorySalesViewModel(IDataView dataView)
        {
            _dataView = dataView ?? throw new ArgumentNullException(nameof(dataView));

            _service = new Service();

            _categoriesTitleList = _service.GetCategories().Select(p => p.Title).ToList();

            _productsList = _service.GetProducts().ToList();
        }
        #endregion

        #region Properties
        public List<Models.Product> ProductsList
        {
            get
            {
                if (!string.IsNullOrEmpty(SelectedCategory))
                {
                    var idCategory = _service.GetCategories().Where(c => c.Title == SelectedCategory).FirstOrDefault().Id;
                    _productsList = _service.GetProductsByCategoryId(idCategory).ToList();
                }

                return _productsList;
            }
            set
            {
                _productsList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ProductsList)));
            }
        }

        public List<string> CategoriesTitleList
        {
            get { return _categoriesTitleList; }
            set
            {
                _categoriesTitleList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(CategoriesTitleList)));
            }
        }

        public string SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedCategory)));
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ProductsList)));
            }
        }

        #endregion

        #region Commands
        public RelayCommand ShowMessageCommand
        {
            get
            {
                return _ShowMessageCommand = _ShowMessageCommand ??
                  new RelayCommand(OnShowMessage, CanShowMessage);
            }
        }
        #endregion

        #region Methods
        private bool CanShowMessage()
        {
            return true;
        }

        private void OnShowMessage()
        {
            _dataView.ShowMessage($"Вы ввели: {SelectedCategory} ");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
