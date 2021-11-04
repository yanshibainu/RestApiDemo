using System;
using System.Collections.Generic;
using System.Linq;
using RestApiDemo.Model;

namespace RestApiDemo
{

    public class UsersService : IUsersService
    {
        private List<User> List { get; set; } = new List<User>();

        public List<User> All()
        {
            List.Add(new User
            {
                Id = Guid.NewGuid(),
                Name = "ABC",
                Email = "123@123",
                Password = "123"
            });
            return List;
        }
        public User FindUser(Guid id)
        {
            User result = List.First(t => t.Id == id);
                return result;
        }
        public User AddUser(JSONViewModel input)
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
        public void DeleteUser(Guid id)
        {
            int index = List.FindIndex(t => t.Id == id);
            if (index != -1)
                List.RemoveAt(index);
        }
        public User UpdateUser(Guid id, JSONViewModel input)
        {
            int index = List.FindIndex(t => t.Id == id);
            List[index].Name = input.Name;
            return List[index];
        }
    }
   

}
