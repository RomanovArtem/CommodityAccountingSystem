using System;

namespace CommodityAccountingSystem.Model
{
    /// <summary>
    /// Закупка
    /// </summary>
    public class Purchase
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Дата закупки
        /// </summary>
        public DateTime DatePurchase { get; set; }
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
