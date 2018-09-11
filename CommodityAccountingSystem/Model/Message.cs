using System;

namespace CommodityAccountingSystem.Model
{
    /// <summary>
    /// Сообщения (об окончаниии товаров и тд.)
    /// </summary>
    public class Message
    {
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
