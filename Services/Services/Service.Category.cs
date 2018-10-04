using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public partial class Service
    {
        public Category GetCategoryById(Guid id)
        {
            return _categoryRepository.GetCategoryById(id); ;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.GetCategories(); ;
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }
    }
}
