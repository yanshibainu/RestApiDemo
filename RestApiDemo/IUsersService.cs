using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo
{
    public interface IUsersService
    {
        public List<User> list{ get; set; } 
        public List<User> All();
        public User FindUser(Guid id);

        public User AddUser(JSONViewModel input);
        
        public void DeleteUser(Guid id);
       
    }
}
