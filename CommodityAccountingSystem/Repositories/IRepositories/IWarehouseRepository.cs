using Models;
using System;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface IWarehouseRepository
    {
        /// <summary>
        /// получение склада по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Warehouse GetWarehouseById(Guid id);

        /// <summary>
        /// получение всех складов
        /// </summary>
        /// <returns></returns>
        IEnumerable<Warehouse> GetWarehouses();

        /// <summary>
        /// добавление склада
        /// </summary>
        /// <param name="warehouse"></param>
        void AddWarehouse(Warehouse warehouse);
    }
}
