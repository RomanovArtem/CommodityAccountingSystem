using Repositories.IRepositories;
using Repositories.Repositories;
using Services.IServices;

namespace Services.Services
{
    public partial class Service : IService
    {
        private IProductRepository _productRepository;

        public Service()
        {
            _productRepository = new ProductRepository();
        }
    }
}
