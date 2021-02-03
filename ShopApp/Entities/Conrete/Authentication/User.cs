using SalesManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalesManagement.Entities.Authentication
{
    public class User : IEntity
    {
        public int ID { get ; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        //Back Reference
        public ICollection<UserRole> UserRole { get; set; }
    }
}
