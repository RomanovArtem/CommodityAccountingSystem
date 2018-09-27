using Models;
using System;
using System.Collections.Generic;

namespace Services.IServices
{
    public partial interface IService
    {
        Product GetProductById(Guid id);

        IEnumerable<Product> GetProducts();
    }
}
