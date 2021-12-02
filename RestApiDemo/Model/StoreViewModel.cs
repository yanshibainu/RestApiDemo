using System.ComponentModel.DataAnnotations;
namespace RestApiDemo.Model
{
    public class StoreViewModel
    {
        [Required]
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
    }
}
