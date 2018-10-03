using CommodityAccountingSystem.View.DataView;
using System;
using System.ComponentModel;

namespace CommodityAccountingSystem.ViewModel
{
    public class CategoryViewModel : INotifyPropertyChanged
    {
        #region Fields


        private IDataView _dataView;

        /// <summary>
        /// Выбранная категория
        /// </summary>
        public string _selectedCategory;


        #endregion

        #region Constructors
        public CategoryViewModel(IDataView dataView)
        {
            _dataView = dataView ?? throw new ArgumentNullException(nameof(dataView));
        }
        #endregion

        #region Properties


        #endregion

        #region Commands

        #endregion

        #region Methods


        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}

