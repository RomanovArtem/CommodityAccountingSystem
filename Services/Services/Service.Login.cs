using Models;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public partial class Service
    {
        public bool Authentication(string login, string password)
        {
            return _loginRepository.Authentication(login, password);
        }
    }
}
