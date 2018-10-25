using Ninject;
using Repositories.IRepositories;
using Repositories.Repositories;
using Services.IServices;

namespace Services.Services
{
    public partial class Service : IService
    {
        public static IKernel AppKernel;

        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IHistorySalesRepository _historySalesRepository;
        private ILoginRepository _loginRepository;



        public Service()
        {
            AppKernel = new StandardKernel(new ServiceNinjectModule());

            _productRepository = AppKernel.Get<ProductRepository>();
            _categoryRepository = AppKernel.Get<CategoryRepository>();
            _historySalesRepository = AppKernel.Get<HistorySalesRepository>();
            _loginRepository = AppKernel.Get<LoginRepository>();
        }
    }
}
