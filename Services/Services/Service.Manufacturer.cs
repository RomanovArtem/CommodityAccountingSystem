using Models;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public partial class Service
    {
        public Manufacturer GetManufacturerById(Guid id)
        {
            return _manufacturerRepository.GetManufacturerById(id); ;
        }

        public IEnumerable<Manufacturer> GetManufacturers()
        {
            return _manufacturerRepository.GetManufacturers();
        }

        public void AddManufacturer(Manufacturer manufacturer)
        {
            _manufacturerRepository.AddManufacturer(manufacturer);
        }
    }
}
