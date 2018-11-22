using CommodityAccountingSystem.View;
using CommodityAccountingSystem.View.AddDataView;
using Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.ViewModel.AddDataViewModel
{
    public class AddProductViewModel : INotifyPropertyChanged
    {
        #region Fields

        private string _inputTitleProduct;

        private double _inputPurchasePriceProduct;

        private double _inputSalePriceProduct;

        private RelayCommand _addProductCommand;

        private int _inputCount;

        private double _inputAmount;


        private List<Product> _productsList;

        public string _selectedProduct;

        private Service _service;

        /// <summary>
        /// Список названий категорий 
        /// </summary>
        private List<string> _categoriesTitleList;

        private List<Category> _categoriesList;

        /// <summary>
        /// Выбранная категория
        /// </summary>
        public string _selectedCategory;

        // <summary>
        /// Список названий производителей 
        /// </summary>
        private List<string> _manufacturerTitleList;

        private List<Manufacturer> _manufacturerList;

        /// <summary>
        /// Выбранный производитель
        /// </summary>
        public string _selectedManufacturer;

        /// <summary>
        /// Сервисы
        /// </summary>
        #endregion

        #region Constructors
        public AddProductViewModel(IAddDataView addDataView /*IMainWindows mainWindows*/)
        {

            _service = new Service();

            _categoriesList = _service.GetCategories().ToList();
            _categoriesTitleList = _categoriesList.Select(c => c.Title).ToList();

            _manufacturerList = _service.GetManufacturers().ToList();
            _manufacturerTitleList = _manufacturerList.Select(m => m.Title).ToList();
        }
        #endregion

        #region Properties
        public List<Category> CategoriesList
        {
            get { return _categoriesList; }
            set
            {
                _categoriesList = value;
                CategoriesTitleList = _categoriesList.Select(c => c.Title).ToList();
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(CategoriesList)));
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
            }
        }

        public List<Manufacturer> ManufacturerList
        {
            get { return _manufacturerList; }
            set
            {
                _manufacturerList = value;
                ManufacturerTitleList = _manufacturerList.Select(m => m.Title).ToList();
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ManufacturerList)));
            }
        }

        public List<string> ManufacturerTitleList
        {
            get { return _manufacturerTitleList; }
            set
            {
                _manufacturerTitleList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ManufacturerTitleList)));
            }
        }

        public string SelectedManufacturer
        {
            get { return _selectedManufacturer; }
            set
            {
                _selectedManufacturer = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedManufacturer)));
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
        public List<Product> ProductsList
        {
            get { return _productsList; }
            set
            {
                _productsList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ProductsList)));
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
                return _addProductCommand = _addProductCommand ??
                  new RelayCommand(AddProduct, CanAdd);
            }
        }

        #endregion

        #region Methods
        private bool CanAdd()
        {
            return true;
        }

        private void AddProduct()
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Title = InputTitleProduct,
                PurchasePrice = InputPurchasePriceProduct,
                SalePrice = InputSalePriceProduct,
                CategoryId = _categoriesList.FirstOrDefault(c => c.Title == SelectedCategory).Id,
                ManufacturerId = _manufacturerList.FirstOrDefault(m => m.Title == SelectedManufacturer).Id
            };

            _service.AddProduct(product);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}