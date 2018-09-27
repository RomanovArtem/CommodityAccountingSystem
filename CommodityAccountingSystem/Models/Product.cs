using Models;
using System;

namespace Models
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Product
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Цена закупки
        /// </summary>
        public double PurchasePrice { get; set; }
        /// <summary>
        /// Цена продажи
        /// </summary>
        public double SalePrice { get; set; }
        /// <summary>
        /// Категория товара
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// Производитель (фирма)
        /// </summary>
        public Manufacturer Manufacturer { get; set; }
    }
}
