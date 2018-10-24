using CommodityAccountingSystem.View;
using Services.Services;
using System.ComponentModel;
using System.Windows;

namespace CommodityAccountingSystem.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private RelayCommand _checkUserCommand;

        public string _login;

        public string _password;

        public string _errorText;

        public MainWindow _mainWindow;


        public ILoginWindows LoginWindows { get; set; }
        /// <summary>
        /// Сервисы
        /// </summary>
        private Service _service;

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel()
        {
            _service = new Service();
        }


        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Login)));
            }
        }


        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Password)));
            }
        }

        public string ErrorText
        {
            get { return _errorText; }
            set
            {
                _errorText = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ErrorText)));
            }
        }


        public RelayCommand CheckUserCommand
        {
            get
            {
                return _checkUserCommand = _checkUserCommand ??
                  new RelayCommand(CheckUser, CanCheck);
            }
        }

        private void CheckUser()
        {
            var result = _service.Authentication(Login, Password);

            if (result)
            {
                ErrorText = "";
                _mainWindow = new MainWindow();

                this.LoginWindows.CloseWindow();

                _mainWindow.Show();
            }
            else
            {
                ErrorText = "Неверный логин/пароль. Повторите попытку!";

            }

        }

        private bool CanCheck()
        {
            return true;
        }
    }
}
