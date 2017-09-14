using iScheduler.DAL.EF;
using iScheduler.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iScheduler.WEB.Controllers
{
    public class TestController : Controller
    {
        SchoolContext db = new SchoolContext();
        // GET: Test
        public ActionResult Index()
        {
            db.Classes.Add(new Class());
            db.SaveChanges();

            return View();
        }

        [HttpGet]
        public ActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTeacher(Teacher teacher)
        {

            return View();
        }


    }
}