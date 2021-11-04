using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiDemo.Model;

namespace RestApiDemo
{
    public interface IUsersService
    {
        public List<User> All();
        public User FindUser(Guid id);

        public User AddUser(JSONViewModel input);
        
        public void DeleteUser(Guid id);
        public User UpdateUser(Guid id, JSONViewModel input);
       
    }
}
