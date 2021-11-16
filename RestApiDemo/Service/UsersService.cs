using System;
using System.Collections.Generic;
using System.Linq;
using RestApiDemo.Model;


namespace RestApiDemo.Service
{

    public class UsersService : IUsersService<User, JSONViewModel>
    {

        private List<User> List { get; set; }
        

        public List<User> All()
        {
            var user = new User() {
                Id = Guid.NewGuid(),
                Name = "ABC",
                Email = "123@123",
                Password = "123"
            };
            List = new List<User>();
            List.Add(user);
            return List;
        }
        public User Find(Guid id)
        {
            User result = List.First(t => t.Id == id);
                return result;
        }
        public User Create(JSONViewModel input)
        {
            User result = new User()
            {
                Id = Guid.NewGuid(),
                Name = input.Name,
                Email = input.Email,
                Password = input.Password
            };
            List = new List<User>();
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
            List[index].Name = input.Name;
            return List[index];
        }
    }
   

}
