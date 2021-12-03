using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Model;
using Microsoft.EntityFrameworkCore;
namespace RestApiDemo.Service
{
    public class UsersService : AbstractRepository<User, UserViewModel>
    {
        public UsersService(UserDbContext context) : base(context)
        {

        }

    }
}
