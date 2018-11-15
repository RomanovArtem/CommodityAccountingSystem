using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    /// <summary>
    /// Доходы - расходы
    /// </summary>
    [Table("IncomeAndExpenses")]
    public class IncomeAndExpense
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Расход
        /// </summary>
        public double Expense { get; set; }
        /// <summary>
        /// Доход
        /// </summary>
        public double Income { get; set; }
        /// <summary>
        /// Аренда
        /// </summary>
        public double Rent { get; set; }
        /// <summary>
        /// Зарплата
        /// </summary>
        public double Salary { get; set; }
        /// <summary>
        /// Доставка
        /// </summary>
        public double Delivery { get; set; }
        /// <summary>
        /// Непредвиденные расходы
        /// </summary>
        public double UnforeseenExpenses { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Начало периода
        /// </summary>
        public DateTime BeginPeriod { get; set; }
        /// <summary>
        /// Конец периода
        /// </summary>
        public DateTime EndPeriod { get; set; }

    }
}
