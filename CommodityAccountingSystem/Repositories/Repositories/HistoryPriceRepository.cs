using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class HistoryPriceRepository : BaseRepository, IHistoryPriceRepository
    {
        public void AddHistoryPrice(HistoryPrice historyPrice)
        {
            dbContext.HistoryPrices.Add(historyPrice);
            dbContext.SaveChanges();
        }

        public IEnumerable<HistoryPrice> GetHistoryPrices()
        {
            return dbContext.HistoryPrices.ToList();
        }

        public HistoryPrice GetHistoryPriceById(Guid id)
        {
            return dbContext.HistoryPrices.FirstOrDefault(p => p.Id == id);
        }
    }
}
