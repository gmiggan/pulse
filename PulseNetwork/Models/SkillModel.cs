using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PulseNetwork.Models
{
    public class Skill
    {
        public int ID { get; set; }
        public String skillName { get; set; }
        public String skillDescription { get; set; }
    }

    public class SkillDBContext : PulseDbContext
    {
        public DbSet<Skill> Skills { get; set; }
    }
}
