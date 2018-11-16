using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class WarehouseRepository : BaseRepository, IWarehouseRepository
    {
        public void AddWarehouse(Warehouse warehouse)
        {
            dbContext.Warehouses.Add(warehouse);
            dbContext.SaveChanges();
        }

        public Warehouse GetWarehouseById(Guid id)
        {
            return dbContext.Warehouses.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Warehouse> GetWarehouses()
        {
            return dbContext.Warehouses.ToList();
        }
    }
}
