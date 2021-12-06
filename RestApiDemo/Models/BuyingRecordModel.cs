using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Models
{
    public class BuyingRecordModel
    {
        public string UserName { get; set; }
        public string StoreName { get; set; }
        public double totalPrice { get; set; }
        public int NumberOfOrder { get; set; }
    }
}
