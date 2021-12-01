using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiDemo.Model
{
    public class Order
    {
        public Guid OrderId { get; set; }
        
        
        public DateTime Date { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
    }
}
