using iScheduler.BLL.Interfaces;
using iScheduler.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace iScheduler.WEB.Controllers
{
    public class ClassController : Controller
    {
        IClassService classService;

        public ClassController(IClassService service)
        {

        }

        public ActionResult Home()
        {
            return View();
        }
    }
}
