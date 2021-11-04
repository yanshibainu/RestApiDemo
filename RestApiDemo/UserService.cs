using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiDemo
{

    public class UsersService : IUsersService
    {

        public List<User> list { get; set; }
        public UsersService() { new List<User>(); } 

        public List<User> All()
        {
            list.Add(new User
            {
                Id = Guid.NewGuid(),
                Name = "ABC",
                Email = "123@123",
                Password = "123"
            });
            return list;
        }
        public User FindUser(Guid id)
        {
            User result = list.First(t => t.Id == id);
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
            list.Add(result);
            return result;
        }
        public void DeleteUser(Guid id)
        {
            int index = list.FindIndex(t => t.Id == id);
            if (index != -1)
                list.RemoveAt(index);
        }
        public User UpdateUser(Guid id, JSONViewModel input)
        {
            int index = list.FindIndex(t => t.Id == id);
            list[index].Name = input.Name;
            return list[index];
        }
    }
   

}
