using System;
using System.ComponentModel;

namespace CommodityAccountingSystem.View
{
    public class FirstViewModel : INotifyPropertyChanged
    {
        #region Fields
        private IMainWindows _MainWindows;

        /// <summary>
        /// Введенная строка в TextBox
        /// </summary>
        public string _InputText;

        /// <summary>
        /// Сообщение пользователю
        /// </summary>
        private RelayCommand _ShowMessageCommand;
        #endregion

        #region Constructors
        public FirstViewModel(IMainWindows mainWindows)
        {
            _MainWindows = mainWindows ?? throw new ArgumentNullException(nameof(mainWindows));
        }
        #endregion

        #region Properties
        public string InputText
        {
            get { return _InputText; }
            set
            {
                _InputText = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(InputText)));
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
            _MainWindows.ShowMessage($"Вы ввели: {InputText}");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}