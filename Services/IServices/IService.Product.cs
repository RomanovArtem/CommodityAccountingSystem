using Models;
using System;

namespace Services.IServices
{
    public partial interface IService
    {
        Product GetProductById(Guid id);
    }
}
