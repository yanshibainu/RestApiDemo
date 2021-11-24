using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using RestApiDemo.Model;
using RestApiDemo.Service;


namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : AbstractController<User, JSONViewModel>
    {
        private readonly UserDbContext _context;
        public UserController(IService<User, JSONViewModel> usersService, UserDbContext context) : base(usersService)
        {
            _context = context;
        }
    }
}

