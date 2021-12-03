using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Model;
using Microsoft.EntityFrameworkCore;
namespace RestApiDemo.Service
{
    public class ProductsService : AbstractRepository<Product, ProductViewModel>
    {
        public ProductsService(UserDbContext context) : base(context)
        {

        }

    }
}
