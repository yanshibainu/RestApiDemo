using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;



namespace RestApiDemo.Controllers
{

    [ApiController]
    [Route("api/user/[controller]")]

    public class UserController : Controller
    {

        private static IUsersService _usersService;
        public UserController(IUsersService usersServive) 
        {

            _usersService = usersServive;
        }
        //UsersService _usersService = new UsersService();



        [HttpGet]
        public List<User> Index()
        {
            return _usersService.All();
        }

        [HttpGet("{id}")]
        public User Index(Guid id)
        {

            return _usersService.FindUser(id);
        }

        [HttpPost]
        public User Index(JSONViewModel input)
        {
            return _usersService.AddUser(input);
        }

        [HttpPut("{id}")]
        public User Index(Guid id, JSONViewModel input)
        {
            return _usersService.UpdateUser(id, input);
        }
        
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {

            _usersService.DeleteUser(id);

        }
    }
}
