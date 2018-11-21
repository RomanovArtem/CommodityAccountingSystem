using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class HistorySalesRepository : BaseRepository, IHistorySalesRepository
    {
        public HistorySales GetHistorySalesById(Guid id)
        {
            return dbContext.HistorySales.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<HistorySales> GetHistorySales()
        {
            var historySales = dbContext.HistorySales.ToList();
            foreach (var historySale in historySales)
            {
                historySale.Product = dbContext.Products.FirstOrDefault(c => c.Id == historySale.ProductId);
            }

            return historySales;
        }

        public void AddHistorySales(HistorySales historySales)
        {
            dbContext.HistorySales.Add(historySales);
            dbContext.SaveChanges();
        }
    }
}
