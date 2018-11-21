using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    /// <summary>
    /// Закупка
    /// </summary>
    [Table("Purchases")]
    public class Purchase
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Дата закупки
        /// </summary>
        public DateTime DatePurchase { get; set; }
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
        /// Цена закупки
        /// </summary>
        public double PurchasePrice { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Сумма
        /// </summary>
        public double Amount { get; set; }
    }
}
