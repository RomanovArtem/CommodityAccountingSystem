using System;

namespace Models
{
    /// <summary>
    /// Категория
    /// </summary>
    public class Category
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; }
    }
}
