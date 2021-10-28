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
        private static List<Data> users = new List<Data>();


        [HttpGet("api/user")]
        public List<Data> Get()
        {
            return users;
        }

        [HttpGet("api/user/{id}")]
        public Data Get(int id)
        {
            var result = users.First(t => t.Id == id);
            return result;
        }

        [HttpPost("api/user")]
        public Data Post([FromBody] JSONViewModle input)
        {
            var result = new Data { Id = users.Count() == 0 ? 1 : users[users.Count() - 1].Id + 1, Name = input.Name, Email = input.Email, Password = input.Password };
            users.Add(result);

            return result;

        }

        [HttpDelete("api/user/{id}")]
        public void Delete(int id)
        {

            int index = users.FindIndex(t => t.Id == id);
            users.RemoveAt(index);


        }
    }
}
