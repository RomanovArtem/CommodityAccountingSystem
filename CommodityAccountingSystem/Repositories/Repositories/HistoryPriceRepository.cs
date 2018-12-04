using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class HistoryPriceRepository : BaseRepository, IHistoryPriceRepository
    {
        public void AddHistoryPrices(HistoryPrice historyPrice)
        {
            dbContext.HistoryPrices.Add(historyPrice);
            dbContext.SaveChanges();
        }

        public IEnumerable<HistoryPrice> GetHistoryPrices()
        {
            var historyPrices = dbContext.HistoryPrices.ToList();

            foreach (var historyPrice in historyPrices)
            {
                historyPrice.Product = dbContext.Products.FirstOrDefault(p => p.Id == historyPrice.ProductId);
            }

            return historyPrices;
        }

        public HistoryPrice GetHistoryPricesById(Guid id)
        {
            return dbContext.HistoryPrices.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<HistoryPrice> GetHistoryPricesByProductId(Guid productId)
        {
            return dbContext.HistoryPrices
                .Where(hp => hp.ProductId == productId)
                .OrderBy(hp => hp.InstallationDateNewPrice)
                .ToList();
        }
    }
}
