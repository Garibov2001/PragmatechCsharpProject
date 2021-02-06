using SalesManagement.Entities.Authentication;
using ShopApp.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Utilities.Validations
{
    public static class AdminLoginFormValidation
    {
        private static UnitOfWork _unitOfWork;
        static AdminLoginFormValidation()
        {
            _unitOfWork = new UnitOfWork();
        }

        public static User CheckAccount(string _password, string _email)
        {
            var user = _unitOfWork.Users.Get(x => x.Password == _password && x.Email == _email);
            var role = _unitOfWork.Roles.Get(x => x.Name == "Admin");

            if (user == null) return null;

            var isAdmin = _unitOfWork.UsersRoles.Get(x => x.UserID == user.ID && x.RoleID == role.ID);
            return isAdmin == null ? null : user;
        }
    }
}
