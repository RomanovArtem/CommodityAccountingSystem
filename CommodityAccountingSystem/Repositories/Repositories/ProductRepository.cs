using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProductById(Guid id)
        {
            var product = DataBase.Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            return DataBase.Products;
        }
    }
}
