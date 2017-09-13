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
        // GET: Test
        public ActionResult Index()
        {
            SchoolContext db = new SchoolContext();
            db.Classes.Add(new Class());
            db.SaveChanges();

            return View();
        }
    }
}