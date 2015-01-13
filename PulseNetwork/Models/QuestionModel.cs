using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PulseNetwork.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionBody { get; set; }
        public DateTime? DatePosted { get; set; }
        public TimeSpan? TimePosted { get; set; }

        public void getUsername()
        {
            
            
        }
    
    
    
    }

    

    public class QuestionDbContext : PulseDbContext
    {
        public DbSet<Question> Questions { get; set; }
    }
}