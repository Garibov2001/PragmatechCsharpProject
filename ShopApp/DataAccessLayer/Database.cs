using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccessLayer
{
    static class Database
    {
        //Database
        private static List<User> _users;
        //Static constructor
        static Database()
        {
            _users = new List<User>();
        }

        public static void AddUser(User user)
        {
            _users.Add(user);
        }

        public static void RemoveUser(int id)
        {
            var user = _users.SingleOrDefault(x => x.ID == id);
            _users.Remove(user);
        }

        public static List<User> GetAll()
        {
            return _users;
        }

        public static User GetById(int id)
        {
            return _users.SingleOrDefault(x => x.ID == id); ;
        }

    }
}
