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
        private UserDbContext _context;
        public UsersService(UserDbContext context)
        {
            _context = context;
        }
        public List<User> All()
        {
            var List = _context.Users.ToList();
            return List;
        }
        public User Find(Guid id)
        {
            User result = _context.Users.First(t => t.Id == id);
            return result;
        }
        public User Create(JSONViewModel input)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Name = input.Name,
                Email = input.Email,
                Password = input.Password
            };
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }
        public void Delete(Guid id)
        {
            var deleteItem = _context.Users.First(x => x.Id == id);
            _context.Users.Remove(deleteItem);
            _context.SaveChanges();
        }
        public User Edit(Guid id, JSONViewModel input)
        {
            var editItem = _context.Users.First(x => x.Id == id);
            _context.Entry(editItem).CurrentValues.SetValues(input);
            _context.SaveChanges();
            editItem = _context.Users.First(x => x.Id == id);
            return editItem;
        }
    }
}
