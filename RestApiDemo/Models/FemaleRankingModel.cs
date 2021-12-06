using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Models
{
    public class FemaleRankingModel
    {
        public string ProductName { get; set; }
        public int amount { get; set; }
        public double ProductPrice { get; set; }
        public double totalPrice { get; set; }
        public int NumberOfOrder { get; set; }
    }
}
