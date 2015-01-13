using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PulseNetwork.Models;
using System.Net;
using Microsoft.AspNet.Identity;

namespace PulseNetwork.Controllers
{
    public class QuestionController : Controller
    {
        private QuestionDbContext db = new QuestionDbContext();

        public ActionResult Index()
        {
            return View(db.Questions.ToList());
        }

        // GET: /Questions/Details/id
        public ActionResult Details(int id)
        {
            Question question = db.Questions.Find(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // GET: /Questions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Questions/Create
        [HttpPost]
        public ActionResult Create(Question question)
        {
            if (ModelState.IsValid)
            {
                question.UserID = User.Identity.GetUserId();
                question.DatePosted = DateTime.Today;
                question.TimePosted = DateTime.Now.TimeOfDay;
                db.Questions.Add(question);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(question);
        }

        

        //GET: /Questions/ViewQuestion/id
        
        public ActionResult ViewQuestion(int id)
        {
            Question question = db.Questions.Find(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }
    }
}