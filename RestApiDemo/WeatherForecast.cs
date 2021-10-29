using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    public class Data
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public Data(int id, string name, string email, string password) { Id = id; Name = name; Email = email; Password = password; }



    }

    public class Users
    {
        public List<Data> list;
        public Users() { list = new List<Data>(); }
        public Data Find(int id)//id¨¾§b
        {
            Data result = list.FirstOrDefault(t => t.Id == id);
            if (result == null)
                return new Data(-1, null, null, null);
            else
                return result;
        }
        public Data AddUser(string name, string email, string passwd)
        {
            Data result = new Data(list.Count() == 0 ? 1 : list[this.list.Count() - 1].Id + 1, name, email, passwd);
            list.Add(result);
            return result;
        }
        public void DeleteUser(int id)
        {
            int index = list.FindIndex(t => t.Id == id);
            if (index != -1)
                list.RemoveAt(index);
        }
    }

    public class JSONViewModle
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
