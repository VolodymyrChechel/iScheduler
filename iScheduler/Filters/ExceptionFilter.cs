using System.Web.Mvc;

namespace iScheduler.WEB.Filters
{
    public class ExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext exceptionContext)
        {
            exceptionContext.ExceptionHandled = true;

            exceptionContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };

        }
    }
}