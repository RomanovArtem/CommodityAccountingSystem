using Models;
using System;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface IManufacturerRepository
    {
        /// <summary>
        /// получение производителя по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Manufacturer GetManufacturerById(Guid id);

        /// <summary>
        /// получение всех производителей
        /// </summary>
        /// <returns></returns>
        IEnumerable<Manufacturer> GetManufacturers();

        /// <summary>
        /// добавление производителя
        /// </summary>
        /// <param name="manufacturer"></param>
        void AddManufacturer(Manufacturer manufacturer);
    }
}
