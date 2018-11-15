using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    /// <summary>
    /// Сообщения (об окончаниии товаров и тд.)
    /// </summary>
    [Table("Messages")]
    public class Message
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Содержание
        /// </summary>
        public string Content { get; set; }
    }
}
