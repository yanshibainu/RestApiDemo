using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Models;
namespace RestApiDemo.Controllers
{
    public interface ISelectController
    {
        public List<FemaleRankingModel>FemaleRanking();
        public List<BuyingRecordModel> BuyingRecord();
    }
}