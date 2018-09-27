using System;

namespace Models
{
    /// <summary>
    /// История цен
    /// </summary>
    public class HistoryPrice
    {
        public Guid Id { get; set; }
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
