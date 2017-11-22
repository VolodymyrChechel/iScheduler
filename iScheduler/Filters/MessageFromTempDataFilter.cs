using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iScheduler.WEB.Filters
{
    public class MessageFromTempDataAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var message = context.Controller.TempData["Message"];
            context.Controller.ViewBag.Message = message;
        }
    }
}