using Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.View
{
    public class AddDataViewModel : INotifyPropertyChanged
    {
        #region Fields

        private IMainWindows _mainWindows;

        private string _inputTitleProduct;

        private double _inputPurchasePriceProduct;

        private double _inputSalePriceProduct;

        private List<Category> _categoriesList;

        private RelayCommand _onAddProductCommand;

        /// <summary>
        /// Список названий категорий 
        /// </summary>
        private List<string> _categoriesTitleList;

        /// <summary>
        /// Выбранная категория
        /// </summary>
        public string _selectedCategory;

        /// <summary>
        /// Сервисы
        /// </summary>
        private Service _service;
        #endregion

        #region Constructors
        public AddDataViewModel(IMainWindows mainWindows)
        {
            _mainWindows = mainWindows ?? throw new ArgumentNullException(nameof(mainWindows));

            _service = new Service();

            _categoriesList = _service.GetCategories().ToList();
            _categoriesTitleList = _categoriesList.Select(a => a.Title).ToList();
        }
        #endregion

        #region Properties
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
            }
        }

        public string InputTitleProduct
        {
            get { return _inputTitleProduct; }
            set
            {
                _inputTitleProduct = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(InputTitleProduct)));
            }
        }

        public double InputPurchasePriceProduct
        {
            get { return _inputPurchasePriceProduct; }
            set
            {
                _inputPurchasePriceProduct = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(InputPurchasePriceProduct)));
            }
        }

        public double InputSalePriceProduct
        {
            get { return _inputSalePriceProduct; }
            set
            {
                _inputSalePriceProduct = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(InputSalePriceProduct)));
            }
        }

        #endregion

        #region Commands
        public RelayCommand AddProductCommand
        {
            get
            {
                return _onAddProductCommand = _onAddProductCommand ??
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
            _mainWindows.ShowMessage($"Вы ввели:  {InputTitleProduct},  {InputPurchasePriceProduct}, {InputSalePriceProduct}, {_categoriesList.FirstOrDefault(c => c.Title == SelectedCategory).Id}");
            var product = new Product
            {
                Id = new Guid(),
                Title = InputTitleProduct,
                PurchasePrice = InputPurchasePriceProduct,
                SalePrice =  InputSalePriceProduct,
                Category = _categoriesList.FirstOrDefault(c => c.Title == SelectedCategory)
            };
            _service.AddProduct(product);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}