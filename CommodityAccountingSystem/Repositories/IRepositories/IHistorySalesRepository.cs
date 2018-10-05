using Models;
using System;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface IHistorySalesRepository
    {
        /// <summary>
        /// получение истории по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        HistorySales GetHistorySalesById(Guid Id);

        /// <summary>
        /// получение всех историй
        /// </summary>
        /// <returns></returns>
        IEnumerable<HistorySales> GetHistorySales();

        /// <summary>
        /// добавление истории продажи
        /// </summary>
        /// <param name="historySales"></param>
        void AddHistorySales(HistorySales historySales);
    }
}
