using CommodityAccountingSystem.View;
using CommodityAccountingSystem.View.DataView;
using Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CommodityAccountingSystem.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        #region Fields

        /// <summary>
        /// Список продуктов
        /// </summary>
        private List<Product> _productsList;

        private Product _selectedProduct;

        /// <summary>
        /// Сервисы
        /// </summary>
        private Service _service;
        #endregion

        #region Constructors
        public ProductViewModel(IDataView dataView = null)
        {
            _service = new Service();
            _productsList = _service.GetProducts().ToList();
        }
        #endregion

        #region Properties
        public List<Product> ProductsList
        {
            get { return _productsList; }
            set
            {
                _productsList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ProductsList)));
            }
        }

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedProduct)));
            }
        }
        #endregion

        #region Commands

        #endregion

        #region Methods

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

    }
}
