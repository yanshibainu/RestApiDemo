using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Model;
namespace RestApiDemo
{
    public class UserDbInit
    {
        public static void Initialize(UserDbContext context)
        {
            context.Database.EnsureCreated();
            var user = new User[]
            {
                new User{Id=Guid.NewGuid(),Name="Alexander",Email="Alex@com",Password="Alex"},
                new User{Id=Guid.NewGuid(),Name="Monica",Email="Monica@com",Password="Monica"},
                new User{Id=Guid.NewGuid(),Name="Emma",Email="Emma@com",Password="Emma"},
                new User{Id=Guid.NewGuid(),Name="Jack",Email="Jack@com",Password="Jack"},
            };
            foreach (User s in user)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();
        }
    }
}
