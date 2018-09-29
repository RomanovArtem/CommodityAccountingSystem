using Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.View
{
    public class FirstViewModel : INotifyPropertyChanged
    {
        #region Fields
        /// <summary>
        /// Список категорий для ComboBox
        /// </summary>
        private List<string> productsList;

        private IMainWindows _MainWindows;

        /// <summary>
        /// Введенная строка в TextBox
        /// </summary>
        public string _InputText;

        /// <summary>
        /// Сообщение пользователю
        /// </summary>
        private RelayCommand _ShowMessageCommand;

        /// <summary>
        /// Сервисы
        /// </summary>
        private Service _service;
        #endregion

        #region Constructors
        public FirstViewModel(IMainWindows mainWindows)
        {
            _MainWindows = mainWindows ?? throw new ArgumentNullException(nameof(mainWindows));

            _service = new Service();

            productsList = _service.GetProducts().Select(p=>p.Title).ToList();
        }
        #endregion

        #region Properties
        public List<string> ProductsList
        {
            get { return productsList; }
            set
            {
                productsList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ProductsList)));
            }
        }
        #endregion

        #region Commands
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
        private bool CanShowMessage()
        {
            return true;
        }

        private void OnShowMessage()
        {
            _MainWindows.ShowMessage($"Вы ввели:");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}