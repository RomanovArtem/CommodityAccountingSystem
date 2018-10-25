﻿using AspectInjector.Broker;
using Ninject;
using Repositories.IRepositories;
using Repositories.Repositories;
using Services.IServices;

namespace Services.Services
{
    [Aspect(typeof(MethodTraceAspect))]
    public partial class Service : IService
    {
        public static IKernel _appKernel;
        private readonly MethodTraceAspect _methodTraceAspect;

        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IHistorySalesRepository _historySalesRepository;
        private ILoginRepository _loginRepository;



        public Service()
        {
            _appKernel = new StandardKernel(new ServiceNinjectModule());

            _productRepository = _appKernel.Get<ProductRepository>();
            _categoryRepository = _appKernel.Get<CategoryRepository>();
            _historySalesRepository = _appKernel.Get<HistorySalesRepository>();
            _loginRepository = _appKernel.Get<LoginRepository>();

            this._methodTraceAspect = new MethodTraceAspect();
        }
    }
}
