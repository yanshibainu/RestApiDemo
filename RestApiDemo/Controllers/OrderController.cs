using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using RestApiDemo.Model;
using RestApiDemo.Service;
namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController: AbstractController<Order, OrderViewModel>
    {
        public OrderController(IRepository<Order, OrderViewModel> Service) : base(Service)
        {

        }
    }
}
