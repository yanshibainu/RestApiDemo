using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RestApiDemo.Model;
using RestApiDemo.Service;

namespace RestApiDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();


            /*using (var ctx = new UserDbContext())
            {
                var stud = new User() 
                {
                    Id = Guid.NewGuid(),
                    Name = "default",
                    Email = "default@com",
                    Password = "default"
                };

                ctx.Users.Add(stud);
                ctx.SaveChanges();
            }*/

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
