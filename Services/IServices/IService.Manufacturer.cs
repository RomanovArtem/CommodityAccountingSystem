using Models;
using System;
using System.Collections.Generic;

namespace Services.IServices
{
    public partial interface IService
    {
        Manufacturer GetManufacturerById(Guid id);

        IEnumerable<Manufacturer> GetManufacturers();

        void AddManufacturer(Manufacturer manufacturer);
    }
}
