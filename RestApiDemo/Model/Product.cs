using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestApiDemo.Model
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ICollection<Order> Orders;
        [ForeignKey("Store")]
        public Guid StoreId { get; set; }
        
    }
}
