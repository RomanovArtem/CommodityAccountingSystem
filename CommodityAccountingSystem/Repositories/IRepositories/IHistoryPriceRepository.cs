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
        HistoryPrice GetHistoryPricesById(Guid id);

        /// <summary>
        /// получение всех историй цен
        /// </summary>
        /// <returns></returns>
        IEnumerable<HistoryPrice> GetHistoryPrices();

        /// <summary>
        /// добавление истории цен
        /// </summary>
        /// <param name="historyPrice"></param>
        void AddHistoryPrices(HistoryPrice historyPrice);

        /// <summary>
        /// Получение истории цен для товара
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        IEnumerable<HistoryPrice> GetHistoryPricesByProductId(Guid productId);
    }
}
