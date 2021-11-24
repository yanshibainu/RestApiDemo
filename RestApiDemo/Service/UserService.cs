using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Model;
using Microsoft.EntityFrameworkCore;
namespace RestApiDemo.Service
{
    public class UsersService : IService<User, JSONViewModel>
    {
        private List<User> List= new List<User>() { new User { Id = Guid.NewGuid(), Name = "Alexander", Email = "Alex@com", Password = "Alex" } };
        //private readonly UserDbContext _context;
        public List<User> All()
        {
           /* using (var ctx = new UserDbContext())
            {
                var user = new User()
                {
                    Id = Guid.NewGuid(),
                    Name = "default",
                    Email = "default@com",
                    Password = "default"
                };

                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
            using (UserDbContext context = new UserDbContext())
            {
                var usersList = context.Users.ToList();
                return usersList;
            }*/
            return List;
        }
        public User Find(Guid id)
        {
            User result = List.First(t => t.Id == id);
            return result;
        }
        public User Create(JSONViewModel input)
        {
            User result = new User
            {
                Id = Guid.NewGuid(),
                Name = input.Name,
                Email = input.Email,
                Password = input.Password
            };
            List.Add(result);
            return result;
        }
        public void Delete(Guid id)
        {
            int index = List.FindIndex(t => t.Id == id);
            if (index != -1)
                List.RemoveAt(index);
        }
        public User Edit(Guid id, JSONViewModel input)
        {
            int index = List.FindIndex(t => t.Id == id);
            if (input.Name!=null)
            {
                List[index].Name = input.Name;
            } 
            if(input.Email!=null)
            {
                List[index].Email = input.Email;
            }
            if(input.Password!=null)
            {
                List[index].Password = input.Password;
            }
            return List[index];
        }
    }
}
