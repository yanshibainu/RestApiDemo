using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Model
{
    public class Store
    {
        public Guid StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
    }
}
