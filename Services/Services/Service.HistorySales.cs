using Models;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public partial class Service
    {
        public HistorySales GetHistorySalesById(Guid id)
        {
            return _historySalesRepository.GetHistorySalesById(id); ;
        }


        public IEnumerable<HistorySales> GetHistorySales()
        {
            return _historySalesRepository.GetHistorySales();
        }

        public void AddHistorySales(HistorySales historySalec)
        {
            _historySalesRepository.AddHistorySales(historySalec);
        }
      
    }
}
