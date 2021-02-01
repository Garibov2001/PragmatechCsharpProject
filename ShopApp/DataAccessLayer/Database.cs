using ShopApp.Entity;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccessLayer
{
    public static class Database
    {
        static Database()
        {
            Users = new EntityRepositoryBase<User>();
            Books = new EntityRepositoryBase<Book>();
        }
        public static EntityRepositoryBase<User> Users { get; }
        public static EntityRepositoryBase<Book> Books { get;}

    }
}
