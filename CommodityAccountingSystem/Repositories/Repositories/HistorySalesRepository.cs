using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class HistorySalesRepository : IHistorySalesRepository
    {
        public HistorySales GetHistorySalesById(Guid id)
        {
            var historySales = DataBase.HistorySales.FirstOrDefault(p => p.Id == id);
            return historySales;
        }
        public IEnumerable<HistorySales> GetHistorySales()
        {
            return DataBase.HistorySales.ToList();
        }

        public void AddHistorySales(HistorySales historySales)
        {
            DataBase.HistorySales.Add(historySales);
        }
    }
}
