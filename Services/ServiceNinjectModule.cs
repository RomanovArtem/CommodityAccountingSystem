using Ninject.Modules;
using Repositories.IRepositories;
using Repositories.Repositories;
using Services.IServices;
using Services.Services;

namespace Services
{
    public class ServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IService>().To<Service>().InSingletonScope();
            this.Bind<ICategoryRepository>().To<CategoryRepository>().InSingletonScope();
            this.Bind<IHistorySalesRepository>().To<HistorySalesRepository>().InSingletonScope();
            this.Bind<ILoginRepository>().To<LoginRepository>().InSingletonScope();
            this.Bind<IProductRepository>().To<ProductRepository>().InSingletonScope();
        }
    }
}
