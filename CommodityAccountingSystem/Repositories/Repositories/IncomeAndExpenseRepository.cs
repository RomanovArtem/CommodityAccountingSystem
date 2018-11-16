using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class IncomeAndExpenseRepository : BaseRepository, IIncomeAndExpenseRepository
    {
        public void AddIncomeAndExpense(IncomeAndExpense incomeAndExpense)
        {
            dbContext.IncomeAndExpenses.Add(incomeAndExpense);
            dbContext.SaveChanges();
        }

        public IEnumerable<IncomeAndExpense> GetIncomeAndExpenses()
        {
            return dbContext.IncomeAndExpenses.ToList();
        }

        public IncomeAndExpense GetIncomeAndExpenseById(Guid id)
        {
            return dbContext.IncomeAndExpenses.FirstOrDefault(p => p.Id == id);
        }
    }
}
