using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    /// <summary>
    /// Производитель
    /// </summary>
    [Table("Manufacturers")]
    public class Manufacturer
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Title { get; set; }
    }
}
