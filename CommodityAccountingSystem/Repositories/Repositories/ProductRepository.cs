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
            dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var oldProduct = dbContext.Products.FirstOrDefault(p => p.Id == product.Id);
            if (oldProduct != null)
            {

                // добавить метод для проверки, кто объект изменился (лучше во вью модели)
                // либо возвращать ошибку
                dbContext.Products.Remove(oldProduct);
                dbContext.SaveChanges();
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
            }
        }

        public Product GetProductById(Guid id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = dbContext.Products.ToList();
            foreach (var product in products)
            {
                product.Category = dbContext.Categories.FirstOrDefault(c => c.Id == product.CategoryId);
                product.Manufacturer = dbContext.Manufacturers.FirstOrDefault(m => m.Id == product.ManufacturerId);
            }

            return products;
        }

        public IEnumerable<Product> GetProductsByCategoryId(Guid id)
        {
            return dbContext.Products.Where(p => p.Category.Id == id).ToList();
        }
    }
}
