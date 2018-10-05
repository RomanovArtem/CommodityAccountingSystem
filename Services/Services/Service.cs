using Repositories.IRepositories;
using Repositories.Repositories;
using Services.IServices;

namespace Services.Services
{
    public partial class Service : IService
    {
        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IHistorySalesRepository _historySalesRepository;

        public Service()
        {
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
            _historySalesRepository = new HistorySalesRepository();
        }
    }
}
