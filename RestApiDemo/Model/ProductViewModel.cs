using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Model
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public Guid StoreId { get; set; }
    }
}
