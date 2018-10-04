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

        private string _inputTitleCategory;

        private double _inputPurchasePriceProduct;

        private double _inputSalePriceProduct;

        private RelayCommand _addProductCommand;

        private RelayCommand _addCategoryCommand;

        /// <summary>
        /// Список названий категорий 
        /// </summary>
        private List<string> _categoriesTitleList;

        private List<Category> _categoriesList;

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
            _categoriesTitleList = _categoriesList.Select(c => c.Title).ToList();
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

        public string InputTitleCategory
        {
            get { return _inputTitleCategory; }
            set
            {
                _inputTitleCategory = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(InputTitleCategory)));
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

        public RelayCommand AddCategoryCommand
        {
            get
            {
                return _addCategoryCommand = _addCategoryCommand ??
                  new RelayCommand(AddCategory, CanAdd);
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
                Category = _categoriesList.FirstOrDefault(c => c.Title == SelectedCategory)
            };
            _service.AddProduct(product);
        }

        private void AddCategory()
        {
            var category = new Category
            {
                Id = Guid.NewGuid(),
                Title = InputTitleCategory
            };
            _service.AddCategory(category);

            CategoriesList = _service.GetCategories().ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}