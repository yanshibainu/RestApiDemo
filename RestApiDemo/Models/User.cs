using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiDemo.Model
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your gender.")]
        [StringLength(1)]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter your email.")]
        [StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your password.")]
        [StringLength(30)]
        public string Password { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
