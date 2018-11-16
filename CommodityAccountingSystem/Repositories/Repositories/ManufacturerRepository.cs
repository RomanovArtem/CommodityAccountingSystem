using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using Repositories.IRepositories;


namespace Repositories.Repositories
{
    public class ManufacturerRepository : BaseRepository, IManufacturerRepository
    {
        public void AddManufacturer(Manufacturer manufacturer)
        {
            dbContext.Manufacturers.Add(manufacturer);
            dbContext.SaveChanges();
        }

        public Manufacturer GetManufacturerById(Guid id)
        {
            return dbContext.Manufacturers.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Manufacturer> GetManufacturers()
        {
            return dbContext.Manufacturers.ToList();
        }
    }
}
