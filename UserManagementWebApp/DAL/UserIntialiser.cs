using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserManagementWebApp.Models;
using System.Data.Entity;

namespace UserManagementWebApp.DAL
{
    public class UserIntialiser : DropCreateDatabaseIfModelChanges<UserDbContext>
    {
        protected override void Seed(UserDbContext context)
        {
            var users = new List<User>
            {
                new User{FirstName = "John", LastName = "Doe", Email = "johndoe@email.com", MobileNumber = 07234567890,DateOfBirth = new DateTime(1950, 10, 10), Modified = DateTime.Now},
                new User{FirstName = "John", LastName = "Doe", Email = "JohnDoe@email.com", MobileNumber = 07234567890,DateOfBirth = new DateTime(1950, 10, 10), Modified = DateTime.Now},
                new User{FirstName = "John", LastName = "Doe", Email = "JohnDoe@email.com", MobileNumber = 07234567890,DateOfBirth = new DateTime(1950, 10, 10), Modified = DateTime.Now},
                new User{FirstName = "John", LastName = "Doe", Email = "JohnDoe@email.com", MobileNumber = 07234567890,DateOfBirth = new DateTime(1950, 10, 10), Modified = DateTime.Now},
                new User{FirstName = "John", LastName = "Doe", Email = "JohnDoe@email.com", MobileNumber = 07234567890,DateOfBirth = new DateTime(1950, 10, 10), Modified = DateTime.Now}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

        }
    }
}