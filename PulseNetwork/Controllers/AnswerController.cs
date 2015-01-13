using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PulseNetwork.Models;

namespace PulseNetwork.Controllers
{
    public class AnswerController : Controller
    {
        private AnswerDbContext db = new AnswerDbContext();

        // GET: Answer
        public ActionResult Index()
        {
            return View(db.Answers.ToList());
        }

        // GET: /Answers/Details/id
        public ActionResult Details(int id)
        {
            Answer answer = db.Answers.Find(id);
            if (answer == null)
            {
                return HttpNotFound();
            }
            return View(answer);
        }

        // GET: /Answers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Answers/Create
        [HttpPost]
        public ActionResult Create(Answer answer)
        {
            if (ModelState.IsValid)
            {
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(answer);
        }
    }
}