using System;
using System.ComponentModel;

namespace CommodityAccountingSystem.View
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Fields
        private IMainWindows _MainWindows;

        /// <summary>
        /// Сообщение пользователю
        /// </summary>
        private RelayCommand _ShowMessageCommand;
        #endregion

        #region Constructors
        public MainViewModel(IMainWindows mainWindows)
        {
            _MainWindows = mainWindows ?? throw new ArgumentNullException(nameof(mainWindows));
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
            _MainWindows.ShowMessage("Привет от MainUC");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
