using System;

namespace CommodityAccountingSystem.Model
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
    }
}
