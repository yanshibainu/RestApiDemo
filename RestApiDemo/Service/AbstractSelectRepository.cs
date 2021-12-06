using System;
using System.Collections.Generic;
using System.Linq;
using RestApiDemo.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestApiDemo.Service
{
    public class AbstractSelectRepository:ISelectRepository
    {
        protected readonly UserDbContext _context;
        public AbstractSelectRepository(UserDbContext context)
        {
            _context = context;
        }

        public List<FemaleRankingModel> FemaleRanking()
        {
            var femaleOrders = _context.Orders.Include(u => u.User).Include(p => p.Product).Where(i => i.User.Gender == "F").Select(l => new{ l.Product.ProductPrice, l.Product.ProductName, l.Product.ProductId, l.ProductNumber});
            var allProductId = _context.Products.Select(i => i.ProductId).ToList();
            List<FemaleRankingModel> result = new List<FemaleRankingModel>();
            int orderTimes;
            foreach(Guid product in allProductId)
            {
                var orderList = femaleOrders.Where(p => p.ProductId == product).Select(l => new { l.ProductNumber }).ToList();//all oders in same product;
                int totalAmount = 0;
                foreach(var order in orderList)
                {
                    totalAmount += order.ProductNumber;
                }
                orderTimes = femaleOrders.Where(i => i.ProductId == product).Count();
                if(orderTimes !=0)
                {
                    result.Add(new FemaleRankingModel()
                    {
                        ProductName = femaleOrders.First(p => p.ProductId == product).ProductName,
                        ProductPrice = femaleOrders.First(p => p.ProductId == product).ProductPrice,
                        amount = totalAmount,
                        totalPrice = 0,
                        NumberOfOrder = orderTimes
                    });
                }
                
            }
            foreach(FemaleRankingModel item in result)
            {
                item.totalPrice = item.amount * item.ProductPrice;
            }
           var descendingResult =  result.OrderByDescending(a => a.amount).ToList();
            return descendingResult;
        }
        public int checkTimes(Guid id)
        {
            var femaleOrders = _context.Orders.Include(u => u.User).Include(p => p.Product).Where(i => i.User.Gender == "F").Select(l => new { l.Product.ProductPrice, l.Product.ProductName, l.Product.ProductId });
            var orderTimes = femaleOrders.Where(i => i.ProductId == id).Count();
            return orderTimes;
        }
        public List<BuyingRecordModel> BuyingRecord()
        {
            var dateStart = DateTime.Parse("2021-01-01");
            var dateEnd = DateTime.Parse("2021-06-30");
            var orderData = _context.Orders.Include(u => u.User).Include(p => p.Product).Where(d => d.Date >= dateStart && d.Date <= dateEnd).Select(l => new { l.User.Id, l.Product.ProductId, l.ProductNumber, l.Product.ProductPrice }).ToList();
            var userData = _context.Users.Select(n => new {n.Id, n.Name }).ToList();
            var storeData = _context.Stores.Select(s => new { s.StoreId, s.StoreName }).ToList();
            var productData = _context.Products.Select(s => new { s.StoreId, s.ProductId }).ToList();
           
            List<BuyingRecordModel> result = new List<BuyingRecordModel>();
            foreach(var user in userData)
            {
                var userBuyingRecord = orderData.Where(u => u.Id == user.Id).Select(l => new { l.ProductId, l.ProductNumber, l.ProductPrice });
                foreach(var store in storeData)
                {
                    var productInStore = productData.Where(p => p.StoreId == store.StoreId).Select(s => s.ProductId).ToList();
                    int numberOfOders = 0;
                    double totalPrice = 0;
                    foreach (var product in productInStore)
                    {
                        var userBuyingRecordInStore = userBuyingRecord.Where(p => p.ProductId == product);
                        
                        foreach(var data in userBuyingRecordInStore)
                        {
                            numberOfOders += 1;
                            totalPrice += data.ProductNumber*data.ProductPrice;
                        }
                        
                    }
                    result.Add(new BuyingRecordModel()
                    {
                        UserName = user.Name,
                        StoreName = store.StoreName,
                        totalPrice = totalPrice,
                        NumberOfOrder = numberOfOders
                    });

                }
            }
            var descendingResult = result.OrderBy(u => u.UserName).ThenByDescending(p => p.totalPrice).ToList();
            return descendingResult;
        }
    }
}
