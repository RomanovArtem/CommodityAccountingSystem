using System;

namespace Models
{
    /// <summary>
    /// История продаж
    /// </summary>
    public class HistorySales
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Товар
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Сумма
        /// </summary>
        public double Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
