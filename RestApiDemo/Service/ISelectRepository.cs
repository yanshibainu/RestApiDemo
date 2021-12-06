using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Models;

namespace RestApiDemo.Service
{
    public interface ISelectRepository
    {
        public List<FemaleRankingModel> FemaleRanking();
        public int checkTimes(Guid id);
        public List<BuyingRecordModel> BuyingRecord();
    }
    
}
