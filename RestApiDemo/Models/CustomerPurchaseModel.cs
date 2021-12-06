using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Models
{
    public class CustomerPurchaseModel
    {
        public string UserName { get; set;}
        public string StoreName { get; set; }
        public int NumberOfOrder { get; set; }
        public int totalPrice { get; set; }

    }
}
