using CommodityAccountingSystem.View;
using CommodityAccountingSystem.View.AddDataView;
using Models;
using Services.Services;
using System;
using System.ComponentModel;

namespace CommodityAccountingSystem.ViewModel.AddDataViewModel
{
    public class AddManufacturerViewModel : INotifyPropertyChanged
    {
        #region Fields

        private string _inputTitleManufacturer;

        private RelayCommand _addManufacturerCommand;

        /// <summary>
        /// Сервисы
        /// </summary>
        private Service _service;
        #endregion

        #region Constructors
        public AddManufacturerViewModel(IAddDataView addDataView)
        {
            _service = new Service();
        }
        #endregion

        #region Properties

        public string InputTitleManufacturer
        {
            get { return _inputTitleManufacturer; }
            set
            {
                _inputTitleManufacturer = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(InputTitleManufacturer)));
            }
        }

        #endregion

        #region Commands

        public RelayCommand AddManufacturerCommand
        {
            get
            {
                return _addManufacturerCommand = _addManufacturerCommand ??
                  new RelayCommand(AddManufacturer, CanAdd);
            }
        }
        #endregion

        #region Methods
        private bool CanAdd()
        {
            return true;
        }

        private void AddManufacturer()
        {
            var manufacturer = new Manufacturer
            {
                Id = Guid.NewGuid(),
                Title = InputTitleManufacturer
            };
            _service.AddManufacturer(manufacturer);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
