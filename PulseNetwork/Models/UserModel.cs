using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PulseNetwork.Models
{
    public class User
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Picture { get; set; }
        public long ExperiencePoints { get; set; }
    }

    public class UserDBContext : PulseDbContext
    {
        public DbSet<User> Users { get; set; }
    }
}