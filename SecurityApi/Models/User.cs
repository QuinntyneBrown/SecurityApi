﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityApi.Models
{
    public class User : BaseEntity
    {
        public User()
        {
            this.Roles = new HashSet<Role>();
            this.Groups = new HashSet<Group>();
            this.Accounts = new HashSet<Account>();
        }

        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }

        public DateTime? LastLogin { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
