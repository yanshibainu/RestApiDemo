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
        [Required]
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
    }
}
