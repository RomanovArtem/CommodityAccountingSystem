using CommodityAccountingSystem.Model;
using System;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface IProductRepositories
    {
        /// <summary>
        /// получение товара по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Product GetProductById(Guid Id);

        /// <summary>
        /// получение всех товаров
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> GetProducts();
    }
}
