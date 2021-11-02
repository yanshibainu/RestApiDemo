using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo
{
    interface IUsersService
    {
        public List<User> list{ get; set; }
        public List<User> All();
        public User Find(Guid id);

        public User AddUser(JSONViewModel input);

        public void DeleteUser(Guid id);
       
    }
}
