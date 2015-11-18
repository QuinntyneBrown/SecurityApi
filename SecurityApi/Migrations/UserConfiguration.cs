using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityApi.Data;
using SecurityApi.Models;

namespace SecurityApi.Migrations
{
    public class UserConfiguration
    {
        public static void Seed(SecurityContext context)
        {
            var user = new User()
            {
                Id = 1,
                Username = "qbrown",
                Password = "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=",
                Firstname = "Quinn",
                Lastname = "Brown"
            };

            context.Users.AddOrUpdate(user);

            context.SaveChanges();
        }
    }
}
