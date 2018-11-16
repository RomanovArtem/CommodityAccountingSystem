using Models;
using System;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface IHistoryPriceRepository
    {
        /// <summary>
        /// получение истории цен по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        HistoryPrice GetHistoryPriceById(Guid id);

        /// <summary>
        /// получение всех историй цен
        /// </summary>
        /// <returns></returns>
        IEnumerable<HistoryPrice> GetHistoryPrices();

        /// <summary>
        /// добавление истории цен
        /// </summary>
        /// <param name="historyPrice"></param>
        void AddHistoryPrice(HistoryPrice historyPrice);
    }
}
