using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using RestApiDemo.Model;
using RestApiDemo.Service;
namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : AbstractController<Product, ProductViewModel>
    {
        public ProductController(IRepository<Product, ProductViewModel> Service) : base(Service)
        {
        }
    }
}
