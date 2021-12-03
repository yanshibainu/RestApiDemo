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
        [Required(ErrorMessage = "Please enter the product name.")]
        [StringLength(20)]
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public ICollection<Order> Orders;
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        public Guid StoreId { get; set; }

    }
}
