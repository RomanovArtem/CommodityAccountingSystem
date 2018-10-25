using CommodityAccountingSystem.View;
using Ninject;
using Services;
using Services.IServices;
using Services.Services;
using System.ComponentModel;

namespace CommodityAccountingSystem.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Fields
        private RelayCommand _checkUserCommand;

        private MainWindow _mainWindow;


        private string _login;

        private string _password;

        private string _errorText;

        public static IKernel AppKernel;
        private IService _service;

        #endregion

        #region Constructors
        public LoginViewModel()
        {
            AppKernel = new StandardKernel(new ServiceNinjectModule());
            _service = AppKernel.Get<Service>();
        }
        #endregion

        #region Properties
        public ILoginWindows LoginWindows { get; set; }

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

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Command
        public RelayCommand CheckUserCommand
        {
            get
            {
                return _checkUserCommand = _checkUserCommand ??
                  new RelayCommand(CheckUser, CanCheck);
            }
        }
        #endregion

        #region Methods
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
        #endregion
    }
}
