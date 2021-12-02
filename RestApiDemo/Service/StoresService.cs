using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Model;

namespace RestApiDemo.Service
{
    public class StoresService: AbstractRepository<Store, StoreViewModel>
    {
        public StoresService(DbContext context):base(context)
        {

        }
    }
}
