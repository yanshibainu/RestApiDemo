using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Model;

namespace RestApiDemo.Service
{
    public class OrdersService : AbstractRepository<Order, OrderViewModel>
    {
        public OrdersService(UserDbContext context) : base(context)
        {

        }
    }
}
