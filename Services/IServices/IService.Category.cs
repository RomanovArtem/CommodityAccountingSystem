using Models;
using System;
using System.Collections.Generic;

namespace Services.IServices
{
    public partial interface IService
    {
        Category GetCategoryById(Guid id);

        IEnumerable<Category> GetCategories();

        void AddCategory(Category category);
    }
}
