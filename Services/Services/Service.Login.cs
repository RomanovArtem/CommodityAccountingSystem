namespace Services.Services
{
    public partial class Service
    {
        public bool Authentication(string login, string password)
        {
            _methodTraceAspect.Trace($@"Авторизация: {login}");
            return _loginRepository.Authentication(login, password);
        }
    }
}
