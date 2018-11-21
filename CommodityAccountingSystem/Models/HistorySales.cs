using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    /// <summary>
    /// История продаж
    /// </summary>
    [Table("HistorySales")]
    public class HistorySales
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// id Товара
        /// </summary>
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
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
