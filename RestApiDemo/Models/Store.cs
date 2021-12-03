using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestApiDemo.Model
{
    public class Store
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StoreId { get; set; }
        [Required(ErrorMessage = "Please enter the store name.")]
        [StringLength(20)]
        public string StoreName { get; set; }
        [Required(ErrorMessage = "Please enter the store address .")]
        [StringLength(50)]
        public string StoreAddress { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
