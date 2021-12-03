using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using RestApiDemo.Model;
using RestApiDemo.Service;
namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : AbstractController<Store, StoreViewModel>
    {
        public StoreController(IRepository<Store, StoreViewModel> Service) : base(Service)
        {
        }
    }
}
