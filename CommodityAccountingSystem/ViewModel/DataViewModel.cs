using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.View
{
    public class DataViewModel : INotifyPropertyChanged
    {
        #region Fields
        private IMainWindows _mainWindow;

        /// <summary>
        /// Переход к первой вьюшке
        /// </summary>
        private RelayCommand _LoadFirstUCCommand;

        /// <summary>
        /// Список продуктов для ComboBox
        /// </summary>
        private List<Models.Product> productsList;

        /// <summary>
        /// Сообщение пользователю
        /// </summary>
        private RelayCommand _showMessageCommand;

        /// <summary>
        /// Выбранное число в списке чисел
        /// </summary>
        private string _selectedNumber;

        /// <summary>
        /// Сервисы
        /// </summary>
        private Service _service;

        #endregion

        #region Constructors
        public DataViewModel(IMainWindows mainWindows)
        {
            _mainWindow = mainWindows ?? throw new ArgumentNullException(nameof(mainWindows));

            _service = new Service();

            productsList = _service.GetProducts().ToList();
        }
        #endregion

        #region Properties
        public List<Models.Product> ProductsList
        {
            get { return productsList; }
            set
            {
                productsList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ProductsList)));
            }
        }

        public string SelectedNumber
        {
            get { return _selectedNumber; }
            set
            {
                _selectedNumber = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedNumber)));
            }
        }
        #endregion

        #region Commands
        public RelayCommand LoadFirstUCCommand
        {
            get
            {
                return _LoadFirstUCCommand = _LoadFirstUCCommand ??
                  new RelayCommand(OnLoadFirstUC, CanLoadFirstUC);
            }
        }

        public RelayCommand ShowMessageCommand
        {
            get
            {
                return _showMessageCommand = _showMessageCommand ??
                  new RelayCommand(OnShowMessage, CanShowMessage);
            }
        }
        #endregion

        #region Methods

        private bool CanLoadFirstUC()
        {
            return true;
        }
        private void OnLoadFirstUC()
        {
            _mainWindow.LoadView(ViewType.First);
        }

        private bool CanShowMessage()
        {
            return true;
        }

        private void OnShowMessage()
        {
            _mainWindow.ShowMessage($"Вы выбрали: {SelectedNumber}");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}