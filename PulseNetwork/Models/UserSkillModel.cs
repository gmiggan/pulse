using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PulseNetwork.Models
{
    public class UserSkill
    {
        public int ID { get; set; }
        public String UserID { get; set; }
        public String skillID { get; set; }
        public int Score { get; set; }
    }

    public class UserSkillDBContext : PulseDbContext
    {
        public DbSet<UserSkill> UserSkills { get; set; }
    }
}