using CommodityAccountingSystem.View.DataView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityAccountingSystem.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        #region Fields
       

        private IDataView _dataView;

        /// <summary>
        /// Выбранная категория
        /// </summary>
        public string _selectedCategory;

      
        #endregion

        #region Constructors
        public ProductViewModel(IDataView dataView)
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
