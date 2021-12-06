using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using RestApiDemo.Service;
using System.Threading.Tasks;
using RestApiDemo.Models;

namespace RestApiDemo.Controllers
{
    public abstract class AbstractSelectContorller : Controller, ISelectController
    {
        protected readonly ISelectRepository _service;
        public AbstractSelectContorller(ISelectRepository service)
        {
            _service = service;
        }
        [HttpGet("FemaleRanking")]
        public List<FemaleRankingModel> FemaleRanking()
        {
            return _service.FemaleRanking();
        }
        [HttpGet("record")]
        public List<BuyingRecordModel> BuyingRecord()
        {
            return _service.BuyingRecord();
        }
    }
}
