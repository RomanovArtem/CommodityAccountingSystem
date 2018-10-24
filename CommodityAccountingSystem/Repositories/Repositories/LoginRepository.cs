using Repositories.IRepositories;
using System.Linq;

namespace Repositories.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public bool Authentication(string login, string password)
        {
            var result = DataBase.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            return result != null;
        }
    }
}
