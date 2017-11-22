using System;
using System.Collections.Generic;
using System.Web.Mvc;
using iScheduler.BLL.Interfaces;
using iScheduler.BLL.Services;
using iScheduler.WEB.Util;

namespace iScheduler.WEB.Filters
{
    public class CreateProgramDataAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            IProgramService programService = DependencyResolver.Current.
                GetService(typeof(IProgramService)) as IProgramService;

            var viewBag = filterContext.Controller.ViewBag;

            var classDtoList = programService.GetAllClasses();
            var subjectDtoList = programService.GetAllSubjects();
            var semestersDtoList = programService.GetAllSemesters();

            var classSelectListItems = new List<SelectListItem>();
            foreach (var classItem in classDtoList)
            {
                classSelectListItems.Add(new SelectListItem
                {
                    Text = classItem.Name,
                    Value = classItem.Id.ToString()
                });
            }
            viewBag.ClassListItems = new SelectList(
                classSelectListItems, "Value", "Text", "Select a class");

            var subjectSelectListItems = new List<SelectListItem>();
            foreach (var subjectItem in subjectDtoList)
            {
                subjectSelectListItems.Add(new SelectListItem
                {
                    Text = subjectItem.Name,
                    Value = subjectItem.Id.ToString()
                });
            }
            viewBag.SubjectListItems = new SelectList(
                subjectSelectListItems, "Value", "Text", "Select a subject");

            DateTime currentDate = DateTime.UtcNow;
            var semesterSelectListItems = new List<SelectListItem>();
            foreach (var semesterItem in semestersDtoList)
            {
                semesterSelectListItems.Add(new SelectListItem
                {
                    Text = semesterItem.Name,
                    Value = semesterItem.Id.ToString(),
                    Selected = currentDate.IsInRange(semesterItem.Start, semesterItem.Finish)
                });
            }
            viewBag.SemesterListItems = new SelectList(
                semesterSelectListItems, "Value", "Text", "Select one");
        }
    }
}