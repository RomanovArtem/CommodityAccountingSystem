using System;
using System.Collections.Generic;

namespace Models
{
    /// <summary>
    /// Чек
    /// </summary>
    public class Check
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Номер
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Дата продажи
        /// </summary>
        public DateTime DateSale { get; set; }
        /// <summary>
        /// Сумма
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// Истории продаж
        /// </summary>
        public List<HistorySales> HistorySales { get; set; }
    }
}
