using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class CheckRepository : BaseRepository, ICheckRepository
    {
        public void AddCheck(Check check)
        {
            dbContext.Checks.Add(check);
            dbContext.SaveChanges();
        }

        public IEnumerable<Check> GetChecks()
        {
            return dbContext.Checks.ToList();
        }

        public Check GetCheckById(Guid id)
        {
            return dbContext.Checks.FirstOrDefault(p => p.Id == id);
        }
    }
}
