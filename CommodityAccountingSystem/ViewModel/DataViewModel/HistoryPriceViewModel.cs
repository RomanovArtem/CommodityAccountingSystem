using CommodityAccountingSystem.View;
using CommodityAccountingSystem.View.AddDataView;
using CommodityAccountingSystem.View.DataView;
using Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;


namespace CommodityAccountingSystem.ViewModel.DataViewModel
{
    public class HistoryPriceViewModel : INotifyPropertyChanged
    {
        #region Fields

        private int _oldSalePrice;

        private double _inputAmount;

        private DateTime _inputDate;

        private List<string> _productsTitleList;

        private List<Product> _productsList;

        public string _selectedProduct;

        private RelayCommand _addSaleCommand;

        private Service _service;

        private List<HistoryPrice> _historyPrices;

        /// <summary>
        /// Сообщение пользователю
        /// </summary>
        private RelayCommand _ShowMessageCommand;
        #endregion

        #region Constructors
        public HistoryPriceViewModel(IDataView dataView = null)
        {

            _service = new Service();

            _productsList = _service.GetProducts().ToList();
            _productsTitleList = _productsList.Select(c => c.Title).ToList();

            _historyPrices = _service.GetHistoryPrices().ToList();
        }
        #endregion

        #region Properties
        public List<Product> ProductsList
        {
            get { return _productsList; }
            set
            {
                _productsList = value;
                ProductsTitleList = _productsList.Select(c => c.Title).ToList();
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ProductsList)));
            }
        }

        public List<HistoryPrice> HistoryPricesList
        {
            get
            {
                if (!string.IsNullOrEmpty(SelectedProduct))
                {
                    var productId = ProductsList.FirstOrDefault(p => p.Title == SelectedProduct).Id;
                    _historyPrices = _service.GetHistoryPricesByProductId(productId).ToList();
                }

                return _historyPrices;
            }
            set
            {
                _historyPrices = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(HistoryPricesList)));
            }
        }

        public List<string> ProductsTitleList
        {
            get { return _productsTitleList; }
            set
            {
                _productsTitleList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ProductsTitleList)));
            }
        }

        public string SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;

                PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedProduct)));
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(HistoryPricesList)));
            }
        }

        public int OldSalePrice
        {
            get { return _oldSalePrice; }
            set
            {
                _oldSalePrice = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(OldSalePrice)));
            }
        }

        public double InputAmount
        {
            get { return _inputAmount; }
            set
            {
                _inputAmount = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(InputAmount)));
            }
        }

        public DateTime InputDate
        {
            get { return _inputDate; }
            set
            {
                _inputDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(InputDate)));
            }
        }
        #endregion

        #region Commands
        public RelayCommand AddSaleCommand
        {
            get
            {
                return _addSaleCommand = _addSaleCommand ??
                  new RelayCommand(AddSale, CanAdd);
            }
        }


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
        private bool CanAdd()
        {
            return true;
        }

        private void AddSale()
        {
            var historySales = new HistorySales
            {
                Id = Guid.NewGuid(),
                ProductId = ProductsList.FirstOrDefault(p => p.Title == SelectedProduct).Id,
                Amount = InputAmount,
                Date = InputDate
            };
            _service.AddHistorySales(historySales);
        }

        private bool CanShowMessage()
        {
            return true;
        }

        private void OnShowMessage()
        {
            // _mainWindows.ShowMessage("Привет от MainUC");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
