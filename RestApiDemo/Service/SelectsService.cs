using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using RestApiDemo.Models;

namespace RestApiDemo.Service
{
    public class SelectsService: AbstractSelectRepository
    {
        public SelectsService(UserDbContext context): base(context)
        {
       
        }
    }
}
