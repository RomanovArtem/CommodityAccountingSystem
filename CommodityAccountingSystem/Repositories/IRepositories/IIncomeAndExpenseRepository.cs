using Models;
using System;
using System.Collections.Generic;

namespace Repositories.IRepositories
{
    public interface IIncomeAndExpenseRepository
    {
        /// <summary>
        /// получение доходов - расходов по id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IncomeAndExpense GetIncomeAndExpenseById(Guid id);

        /// <summary>
        /// получение всех доходов - расходов
        /// </summary>
        /// <returns></returns>
        IEnumerable<IncomeAndExpense> GetIncomeAndExpenses();

        /// <summary>
        /// добавление дохода - расхода
        /// </summary>
        /// <param name="check"></param>
        void AddIncomeAndExpense(IncomeAndExpense incomeAndExpense);
    }
}
