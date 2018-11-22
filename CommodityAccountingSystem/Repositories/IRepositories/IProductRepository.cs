using Models;
using System;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface IProductRepository
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

        /// <summary>
        /// получение товаров по id категории
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<Product> GetProductsByCategoryId(Guid id);

        /// <summary>
        /// добавление товара
        /// </summary>
        /// <param name="product"></param>
        void AddProduct(Product product);

        /// <summary>
        /// обновление товара
        /// </summary>
        /// <param name="product"></param>
        void UpdateProduct(Product product);
    }
}
