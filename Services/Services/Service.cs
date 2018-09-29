using Repositories.IRepositories;
using Repositories.Repositories;
using Services.IServices;

namespace Services.Services
{
    public partial class Service : IService
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;

        public Service()
        {
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
        }
    }
}
