using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PulseNetwork.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; } 
    }

    public class ProfileDBContext : PulseDbContext
    {
        public DbSet<Profile> Users { get; set; }
    }
}