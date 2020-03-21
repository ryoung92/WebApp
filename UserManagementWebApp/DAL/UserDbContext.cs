using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserManagementWebApp.Models;

namespace UserManagementWebApp.DAL
{
    public class UserDbContext : DbContext
    {

        public UserDbContext() : base("UserDbContext")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}