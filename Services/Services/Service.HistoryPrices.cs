using Models;
using System;
using System.Collections.Generic;
namespace Services.Services
{
    public partial class Service
    {
        public HistoryPrice GetHistoryPricesById(Guid id)
        {
            return _historyPriceRepository.GetHistoryPricesById(id); ;
        }

        public IEnumerable<HistoryPrice> GetHistoryPrices()
        {
            return _historyPriceRepository.GetHistoryPrices();
        }

        public void AddHistoryPrices(HistoryPrice historyPrice)
        {
            _historyPriceRepository.AddHistoryPrices(historyPrice);
        }

        public IEnumerable<HistoryPrice> GetHistoryPricesByProductId(Guid productId)
        {
            return _historyPriceRepository.GetHistoryPricesByProductId(productId); ;
        }
    }
}
