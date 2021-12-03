using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RestApiDemo.Model
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }
        [Required(ErrorMessage = "Please　enter the date.")]
        public DateTime Date { get; set; }
        
        [ForeignKey("UserId")]
        public User User { get; set; }
        [Required(ErrorMessage = "Please enter the user ID number.")]
        public Guid UserId { get; set; }
        
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [Required(ErrorMessage = "Please enter the product ID number.")]
        public Guid ProductId { get; set; }
    }
}
