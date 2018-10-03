using CommodityAccountingSystem.View.DataView;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        #region Fields
        private IDataView _dataView;

        /// <summary>
        /// Список продуктов
        /// </summary>
        private List<Models.Product> productsList;

        /// <summary>
        /// Сервисы
        /// </summary>
        private Service _service;



        #endregion

        #region Constructors
        public ProductViewModel(IDataView dataView)
        {
            _dataView = dataView ?? throw new ArgumentNullException(nameof(dataView));

            _service = new Service();

            productsList = _service.GetProducts().ToList();
        }
        #endregion

        #region Properties
        public List<Models.Product> ProductsList
        {
            get { return productsList; }
            set
            {
                productsList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ProductsList)));
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
