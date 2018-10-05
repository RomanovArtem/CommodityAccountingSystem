using Models;
using System;
using System.Collections.Generic;

namespace Services.IServices
{
    public partial interface IService
    {
        HistorySales GetHistorySalesById(Guid Id);

        IEnumerable<HistorySales> GetHistorySales();

        void AddHistorySales(HistorySales historySales);
    }
}
