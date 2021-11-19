using System;
using System.Collections.Generic;
using System.Linq;
using RestApiDemo.Model;


namespace RestApiDemo.Service
{

    public class UsersService:IService<User, JSONViewModel>//: AbstractService<User, JSONViewModel>
    {
        public UsersService()
        {
        }
        private List<User> List { get; set; } = new List<User>();
        public IService<User, JSONViewModel> _UsersService { get; }
        public List<User> All()
        {
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
            if (input.Name != null)
            {
                List[index].Name = input.Name;
            }
            if (input.Email != null)
            {
                List[index].Email = input.Email;
            }
            if (input.Password != null)
            {
                List[index].Password = input.Password;
            }
            return List[index];
        }
    }
 }
