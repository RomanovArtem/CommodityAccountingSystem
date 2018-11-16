using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class PurchaseRepository : BaseRepository, IPurchaseRepository
    {
        public void AddPurchase(Purchase purchase)
        {
            dbContext.Purchases.Add(purchase);
            dbContext.SaveChanges();
        }

        public IEnumerable<Purchase> GetPurchases()
        {
            return dbContext.Purchases.ToList();
        }

        public Purchase GetPurchaseById(Guid id)
        {
            return dbContext.Purchases.FirstOrDefault(p => p.Id == id);
        }
    }
}
