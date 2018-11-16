using Models;
using System;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// получение пользователя по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User GetUserById(Guid id);

        /// <summary>
        /// получение всех пользователей
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> GetUsers();

        /// <summary>
        /// добавление пользователя
        /// </summary>
        /// <param name="user"></param>
        void AddUser(User user);
    }
}
