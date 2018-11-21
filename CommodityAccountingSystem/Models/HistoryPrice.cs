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
        /// Старая цена
        /// </summary>
        public double OldPrice { get; set; }
        /// <summary>
        /// Новая цена
        /// </summary>
        public double NewPrice { get; set; }
        /// <summary>
        /// Дата установки новой цены
        /// </summary>
        public DateTime InstallationDateNewPrice { get; set; }
    }
}
