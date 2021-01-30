using SalesManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManagement.Entities.Authentication
{
    public class UserRole : IEntity
    {
        public int ID { get; set; }

        // Relationship One-to-One with User table
        public int UserID { get; set; }
        public User User { get; set; }

        // Relationship One-to-Maney with Role table
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}
