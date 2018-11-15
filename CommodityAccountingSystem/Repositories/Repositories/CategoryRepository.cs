using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public Category GetCategoryById(Guid id)
        {
            var categories = dbContext.Categories.FirstOrDefault(p => p.Id == id);
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
