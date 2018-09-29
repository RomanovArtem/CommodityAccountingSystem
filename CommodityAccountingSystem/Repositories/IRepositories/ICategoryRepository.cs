using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepositories
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// получение категории по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Category GetCategoryById(Guid Id);

        /// <summary>
        /// получение всех категорий
        /// </summary>
        /// <returns></returns>
        IEnumerable<Category> GetCategories();
    }
}
