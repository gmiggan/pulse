using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PulseNetwork.Models
{
    public class Answer
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int QuestionID { get; set; }
        public string AnswerBody { get; set; }
    }

    public class AnswerDbContext : PulseDbContext
    {
        public DbSet<Answer> Answers { get; set; }
    }
}