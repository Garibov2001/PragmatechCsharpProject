using SalesManagement.Entities;
using SalesManagement.Entities.Authentication;
using ShopApp.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccessLayer.Concrete
{
    class UserDal : EntityRepositoryBase<User>
    {
        public bool IsUniqueUser(User entity)
        {
            if (Get(x => x.Email == entity.Email) == null)
            {
                return true;
            }

            return false;
        }

    }
}
