using iScheduler.BLL.Infrastructure;
using iScheduler.BLL.Interfaces;
using iScheduler.BLL.Services;
using iScheduler.WEB.Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace iScheduler.WEB.Util
{
    public static class IocConfigurator
    {
        public static void ConfigureIocUnityContainer()
        {
            IUnityContainer container = new UnityContainer();

            registerService(container);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static void registerService(IUnityContainer container)
        {
            container.AddExtension(new UnityExtension("SchoolConnection"));
            container.RegisterType<IClassService, ClassService>();
            container.RegisterType<ITeacherService, TeacherService>();
            container.RegisterType<ISubjectService, SubjectService>();
            container.RegisterType<IProgramService, ProgramService>();
        }
       
    }
}