using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category GetCategoryById(Guid id)
        {
            var categories = DataBase.Categories.FirstOrDefault(p => p.Id == id);
            return categories;
        }

        public IEnumerable<Category> GetCategories()
        {
            return DataBase.Categories.ToList();
        }

        public void AddCategory(Category category)
        {
            DataBase.Categories.Add(category);
        }
    }
}
