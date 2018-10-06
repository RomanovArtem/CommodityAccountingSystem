using Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.View
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Fields
        private IMainWindows _mainWindows;

        private int _inputCount;

        private double _inputAmount;

        private DateTime _inputDate;

        private List<string> _productsTitleList;

        private List<Product> _productsList;

        public string _selectedProduct;

        private RelayCommand _addSaleCommand;

        private Service _service;

        /// <summary>
        /// Сообщение пользователю
        /// </summary>
        private RelayCommand _ShowMessageCommand;
        #endregion

        #region Constructors
        public MainViewModel(IMainWindows mainWindows)
        {
            _mainWindows = mainWindows ?? throw new ArgumentNullException(nameof(mainWindows));

            _service = new Service();

            _productsList = _service.GetProducts().ToList();
            _productsTitleList = _productsList.Select(c => c.Title).ToList();

            _inputDate = DateTime.Now;
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
                InputAmount = _inputCount * ProductsList.FirstOrDefault(p => p.Title == SelectedProduct).SalePrice;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedProduct)));
            }
        }

        public int InputCount
        {
            get { return _inputCount; }
            set
            {
                _inputCount = value;
                InputAmount = _inputCount * ProductsList.FirstOrDefault(p => p.Title == SelectedProduct).SalePrice;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(InputCount)));
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
                Product = ProductsList.FirstOrDefault(p => p.Title == SelectedProduct),
                Count = InputCount,
                Amount = InputAmount,
                Date = InputDate
            };
            // _mainWindows.ShowMessage($@"{HistorySales.Id}, {HistorySales.Product.Title}, {HistorySales.Count}, {HistorySales.Amount}, {HistorySales.Date}");
            _service.AddHistorySales(historySales);
        }

        private bool CanShowMessage()
        {
            return true;
        }

        private void OnShowMessage()
        {
            _mainWindows.ShowMessage("Привет от MainUC");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
