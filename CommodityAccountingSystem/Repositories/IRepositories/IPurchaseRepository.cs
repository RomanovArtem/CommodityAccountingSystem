using Models;
using System;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface IPurchaseRepository
    {
        /// <summary>
        /// получение закупки по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Purchase GetPurchaseById(Guid id);

        /// <summary>
        /// получение всех закупок
        /// </summary>
        /// <returns></returns>
        IEnumerable<Purchase> GetPurchases();

        /// <summary>
        /// добавление закупки
        /// </summary>
        /// <param name="purchase"></param>
        void AddPurchase(Purchase purchase);
    }
}
