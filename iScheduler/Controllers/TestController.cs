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
            var teachersList = db.Teachers.ToList();

            ViewBag.Program = db.Programs.
                Include(prog => prog.Class).
                Include(prog => prog.Semester).
                Include(prog => prog.Subject).ToList();

            return View(teachersList);
        }

        [HttpGet]
        public ActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTeacher(Teacher teacher)
        {
            if(ModelState.IsValid){
                db.Teachers.Add(teacher);
                db.SaveChanges();
            }

            return View();
        }
        
    }
}