using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using RestApiDemo.Models;
using RestApiDemo.Service;
using System;
using System.Collections.Generic;

namespace RestApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SelectController : AbstractSelectContorller
    {
        public SelectController(ISelectRepository context): base(context)
        {

        }
    }
}
