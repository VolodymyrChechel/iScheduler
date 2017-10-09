using iScheduler.BLL.Util;
using iScheduler.WEB.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace iScheduler
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                {
                    cfg.AddProfile<BllMapperProfile>();
                    cfg.AddProfile<WebMapperProfile>();
                }
            });

            IocConfigurator.ConfigureIocUnityContainer();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
