using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    /// <summary>
    /// Чек
    /// </summary>
    [Table("Checks")]
    public class Check
    {
        [Key]
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
