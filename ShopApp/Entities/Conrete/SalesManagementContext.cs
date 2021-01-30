using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data.Entity;
using SalesManagement.Entities.Authentication;

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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().HasKey(x => x.ID);
        //    modelBuilder.Entity<UserRole>().HasKey(x => x.ID);
        //    modelBuilder.Entity<Role>().HasKey(x => x.ID);
        //}

    }
}
