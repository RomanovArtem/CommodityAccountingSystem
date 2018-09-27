using System;

namespace Models
{
    /// <summary>
    /// Склад
    /// </summary>
    public class Warehouse
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Товар
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }
    }
}
