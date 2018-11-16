using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public void AddUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public User GetUserById(Guid id)
        {
            return dbContext.Users.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return dbContext.Users.ToList();
        }
    }
}
