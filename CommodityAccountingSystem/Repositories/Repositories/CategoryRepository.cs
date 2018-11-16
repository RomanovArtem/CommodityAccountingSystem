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
            return dbContext.Categories.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
        }

        public void AddCategory(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }
    }
}
