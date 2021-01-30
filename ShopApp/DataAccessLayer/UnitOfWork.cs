using ShopApp.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccessLayer
{
    class UnitOfWork
    {
        public UserDal Users { get => new UserDal();}
        public UserRoleDal UsersRoles { get => new UserRoleDal(); }
        public RoleDal Roles { get => new RoleDal(); }
    }
}
