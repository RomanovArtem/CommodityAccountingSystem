using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public CategoryRepository()
        {
            var a = DataBase.Categories;
        }

        public Category GetCategoryById(Guid id)
        {
            var categories = DataBase.Categories.FirstOrDefault(p => p.Id == id);
            return categories;
        }

        public IEnumerable<Category> GetCategories()
        {
            return DataBase.Categories.ToList();
        }
    }
}
