using Models;
using System;
using System.Collections.Generic;


namespace Services.IServices
{
    public partial interface IService
    {
        HistoryPrice GetHistoryPricesById(Guid Id);

        IEnumerable<HistoryPrice> GetHistoryPrices();

        void AddHistoryPrices(HistoryPrice historyPrices);

        IEnumerable<HistoryPrice> GetHistoryPricesByProductId(Guid productId);

    }
}
