using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public partial class Service
    {
        public Product GetProductById(Guid id)
        {
            return _productRepository.GetProductById(id); ;
        }
    }
}
