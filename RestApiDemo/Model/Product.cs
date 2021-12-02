using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestApiDemo.Model
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public ICollection<Order> Orders;
        [ForeignKey("Store")]
        public Guid StoreId { get; set; }
        
    }
}
