using Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    /// <summary>
    /// Товар
    /// </summary>
    [Table("Products")]
    public class Product
    {
        [Key]
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
