using Microsoft.AspNetCore.Mvc;
using RestApiDemo.Model;
using RestApiDemo.Service;



namespace RestApiDemo.Controllers
{

    // [ApiController]
    [Route("api/[controller]")]

    public class UserController: AbstractController<User, JSONViewModel>
    {

        public UserController(IService<User, JSONViewModel> usersService): base(usersService)
        {

        }
        

    }
}
