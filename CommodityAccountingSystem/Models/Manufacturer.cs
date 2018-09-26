using System;

namespace Models
{
    /// <summary>
    /// Производитель
    /// </summary>
    public class Manufacturer
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; }
    }
}
