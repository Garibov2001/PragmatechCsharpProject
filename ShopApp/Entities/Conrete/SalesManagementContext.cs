using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data.Entity;
using SalesManagement.Entities.Authentication;
using ShopApp.Entities.Conrete.Product;

namespace SalesManagement.Entities
{
    public class SalesManagementContext : DbContext
    {
        public SalesManagementContext()
            :base("MainDb")
        {

        }

        // Authentication
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<PurchaseLog> PurchaseLog { get; set; }

    }
}
