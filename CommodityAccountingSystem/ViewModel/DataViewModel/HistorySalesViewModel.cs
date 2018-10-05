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
        /// Список продуктов
        /// </summary>
        private List<Models.HistorySales> _historySales;

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

            _historySales = _service.GetHistorySales().ToList();
        }
        #endregion

        #region Properties
        public List<Models.HistorySales> HistorySalesList
        {
            get { return _historySales; }
            set
            {
                _historySales = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(HistorySalesList)));
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
