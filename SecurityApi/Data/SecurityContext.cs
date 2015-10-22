using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Data;
using SecurityApi.Data.Contracts;
using SecurityApi.Models;

namespace SecurityApi.Data
{
    public class SecurityContext : Common.Data.BaseDbContext, ISecurityContext
    {
        public SecurityContext()
            : base("securityContext")
        {
            
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Session> Sessions { get; set; }

    }
}
