using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CommodityAccountingSystem.View
{
    public class SecondViewModel : INotifyPropertyChanged
    {
        #region Fields
        private IMainWindows _MainWindow;

        /// <summary>
        /// Список чисел для ComboBox
        /// </summary>
        private List<int> _NumbersList;

        /// <summary>
        /// Сообщение пользователю
        /// </summary>
        private RelayCommand _ShowMessageCommand;

        /// <summary>
        /// Выбранное число в списке чисел
        /// </summary>
        private string _SelectedNumber;
        #endregion

        #region Constructors
        public SecondViewModel(IMainWindows mainWindows)
        {
            _MainWindow = mainWindows ?? throw new ArgumentNullException(nameof(mainWindows));

            //создаем список чисел
            _NumbersList = Enumerable.Range(1, 10).ToList();
        }
        #endregion

        #region Properties
        public List<int> NumbersList
        {
            get { return _NumbersList; }
            set
            {
                _NumbersList = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(NumbersList)));
            }
        }

        public string SelectedNumber
        {
            get { return _SelectedNumber; }
            set
            {
                _SelectedNumber = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(SelectedNumber)));
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
            _MainWindow.ShowMessage($"Вы выбрали: {SelectedNumber}");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}