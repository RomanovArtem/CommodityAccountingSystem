using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {

        public void AddProduct(Product product)
        {
            dbContext.Products.Add(product);
        }

        public Product GetProductById(Guid id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByCategoryId(Guid id)
        {
            return dbContext.Products.Where(p => p.Category.Id == id).ToList();
        }
    }
}
