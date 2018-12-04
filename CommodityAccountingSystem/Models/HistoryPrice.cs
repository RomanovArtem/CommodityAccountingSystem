using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    /// <summary>
    /// История цен
    /// </summary>
    [Table("HistoryPrices")]
    public class HistoryPrice
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// id Товара
        /// </summary>
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        /// <summary>
        /// товар
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// Старая цена продажи
        /// </summary>
        public double OldSalePrice { get; set; }
        /// <summary>
        /// Новая цена продажи
        /// </summary>
        public double NewSalePrice { get; set; }
        /// <summary>
        /// Старая цена закупки
        /// </summary>
        public double OldPurchasePrice { get; set; }
        /// <summary>
        /// Новая цена закупки
        /// </summary>
        public double NewPurchasePrice { get; set; }
        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime InstallationDateNewPrice { get; set; }
    }
}
