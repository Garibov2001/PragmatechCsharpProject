using SalesManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalesManagement.Entities.Authentication
{
    public class Role : IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        //Back Reference
        public ICollection<UserRole> UserRole { get; set; }
    }
}
