using Models;
using System;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface ICheckRepository
    {
        /// <summary>
        /// получение чека по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Check GetCheckById(Guid id);

        /// <summary>
        /// получение всех чеков
        /// </summary>
        /// <returns></returns>
        IEnumerable<Check> GetChecks();

        /// <summary>
        /// добавление чека
        /// </summary>
        /// <param name="check"></param>
        void AddCheck(Check check);
    }
}
