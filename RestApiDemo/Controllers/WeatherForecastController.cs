using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;



namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        private static Users users = new Users();


        [HttpGet("api/user")]
        public List<Data> Get()
        {
            return users.list;
        }

        [HttpGet("api/user/{id}")]
        public Data Get(int id)
        {

            return users.Find(id);
        }

        [HttpPost("api/user")]
        public Data Post([FromBody] JSONViewModle input)
        {
            return users.AddUser(input.Name, input.Email, input.Password); ;
        }

        [HttpDelete("api/user/{id}")]
        public void Delete(int id)
        {

            users.DeleteUser(id);

        }
    }
}
