using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class BaseRepository
    {
        protected DataContext dbContext;

        public BaseRepository()
        {
            dbContext = new DataContext();

            var categoriesList = new List<Category>();
            foreach (var category in dbContext.Categories)
            {
                categoriesList.Add(category);
            }
        }
    }
}
