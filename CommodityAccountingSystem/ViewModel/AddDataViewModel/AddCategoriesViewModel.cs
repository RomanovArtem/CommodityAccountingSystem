using CommodityAccountingSystem.View;
using CommodityAccountingSystem.View.AddDataView;
using Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityAccountingSystem.ViewModel.AddDataViewModel
{
    public class AddCategoriesViewModel : INotifyPropertyChanged
    {
        #region Fields

        private IMainWindows _mainWindows;

        private AddCategoriesView _addCategoriesView;

        private string _inputTitleCategory;


        private RelayCommand _addCategoryCommand;


        /// <summary>
        /// Сервисы
        /// </summary>
        private Service _service;
        #endregion

        #region Constructors
        public AddCategoriesViewModel(IAddDataView addDataView /*IMainWindows mainWindows*/)
        {
            _service = new Service();
        }
        #endregion

        #region Properties

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

       
        private void AddCategory()
        {
            var category = new Category
            {
                Id = Guid.NewGuid(),
                Title = InputTitleCategory
            };
            _service.AddCategory(category);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
