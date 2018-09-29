using Models;
using System;
using System.Collections.Generic;

namespace Services.Services
{
    public partial class Service
    {
        public Product GetProductById(Guid id)
        {
            return _productRepository.GetProductById(id); ;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts(); ;
        }
        public IEnumerable<Product> GetProductsByCategoryId(Guid id)
        {
            return _productRepository.GetProductsByCategoryId(id);
        }
    }
}
