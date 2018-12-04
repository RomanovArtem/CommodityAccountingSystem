using CommodityAccountingSystem.View;
using Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.ViewModel.EditDataViewModel
{
    public class EditProductViewModel : INotifyPropertyChanged
    {
        #region Fields

        private Product _editProduct;

        private Service _service;

        private RelayCommand _saveProductCommand;

        private List<Category> _categoriesList;

        private List<Manufacturer> _manufacturerList;

        private string _selectedCategoryTitle;

        private string _selectedManufacturerTitle;

        /// <summary>
        /// Список названий категорий 
        /// </summary>
        private List<string> _categoriesTitleList;

        // <summary>
        /// Список названий производителей 
        /// </summary>
        private List<string> _manufacturerTitleList;
        #endregion

        #region Constructors

        public EditProductViewModel(Product editProduct)
        {
            _editProduct = editProduct;

            _service = new Service();

            _categoriesList = _service.GetCategories().ToList();
            _categoriesTitleList = _categoriesList.Select(c => c.Title).ToList();
            _selectedCategoryTitle = editProduct.Category.Title;

            _manufacturerList = _service.GetManufacturers().ToList();
            _manufacturerTitleList = _manufacturerList.Select(m => m.Title).ToList();
            _selectedManufacturerTitle = editProduct.Manufacturer.Title;

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

        public List<string> ManufacturersTitleList
        {
            get { return _manufacturerTitleList; }
            set
            {
                _manufacturerTitleList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ManufacturersTitleList)));
            }
        }

        public Product EditProduct
        {
            get { return _editProduct; }
            set
            {
                _editProduct = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(EditProduct)));
            }
        }

        public string SelectedCategoryTitle
        {
            get { return _selectedCategoryTitle; }
            set
            {
                _selectedCategoryTitle = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedCategoryTitle)));
            }
        }

        public string SelectedManufacturerTitle
        {
            get { return _selectedManufacturerTitle; }
            set
            {
                _selectedManufacturerTitle = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedManufacturerTitle)));
            }
        }

        #endregion

        #region Commands
        public RelayCommand SaveProductCommand
        {
            get
            {
                return _saveProductCommand = _saveProductCommand ??
                  new RelayCommand(SaveHistoryPriceAndOroduct, CanSave);
            }
        }

        #endregion

        #region Methods

        private bool CanSave()
        {
            return true;
        }

        private void SaveHistoryPriceAndOroduct()
        {
            var oldProduct = _service.GetProductById(EditProduct.Id);
            var newProduct = EditProduct;

            SaveProduct();

            if (oldProduct.SalePrice != newProduct.SalePrice || oldProduct.PurchasePrice == newProduct.PurchasePrice)
            {
                SaveHistoryPrice(oldProduct, newProduct);
            }
        }

        private void SaveProduct()
        {
            var product = EditProduct;
            product.CategoryId = _categoriesList.FirstOrDefault(c => c.Title == SelectedCategoryTitle).Id;
            product.Category = null;

            product.ManufacturerId = _manufacturerList.FirstOrDefault(m => m.Title == SelectedManufacturerTitle).Id;
            product.Manufacturer = null;

            _service.UpdateProduct(product);
        }

        private void SaveHistoryPrice(Product oldProduct, Product newProduct)
        {
            var historyPrice = new HistoryPrice()
            {
                Id = Guid.NewGuid(),
                ProductId = newProduct.Id,
                OldSalePrice = oldProduct.SalePrice,
                NewSalePrice = newProduct.SalePrice,
                OldPurchasePrice = oldProduct.PurchasePrice,
                NewPurchasePrice = newProduct.PurchasePrice,
                InstallationDateNewPrice = DateTime.Now
            };

            _service.AddHistoryPrices(historyPrice);
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
