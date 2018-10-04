using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
        }

        public void AddProduct(Product product)
        {
            DataBase.Products.Add(product);
        }

        public Product GetProductById(Guid id)
        {
            return DataBase.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return DataBase.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByCategoryId(Guid id)
        {
            return DataBase.Products.Where(p => p.Category.Id == id).ToList();
        }
    }
}
