using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.BLL.Interfaces;
using iScheduler.WEB.Filters;
using iScheduler.WEB.Models;

namespace iScheduler.WEB.Controllers
{
    [ExceptionFilter]
    public class SubjectController : Controller
    {
        private readonly ISubjectService subjectService;

        public SubjectController(ISubjectService service)
        {
            subjectService = service;
        }

        public ActionResult Index()
        {
            var subjectsDtoList = subjectService.GetAllSubjects();
            var teachersList = Mapper.Map<IEnumerable<SubjectDto>,
                IEnumerable<SubjectViewModel>>(subjectsDtoList);

            ViewBag.Message = TempData["Message"];
            return View(teachersList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SubjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                var subjectDto = Mapper.Map<SubjectViewModel, SubjectDto>(model);
                subjectService.CreateSubject(subjectDto);

                TempData["Message"] = $"Subject {model.Name}" +
                    " was succesfully created";

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var subjectDto = subjectService.GetSubjectById(id);
            var subject = Mapper.Map<SubjectDto, SubjectViewModel>(subjectDto);

            return View(subject);
        }

        [HttpPost]
        public ActionResult Edit(SubjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                var subjectDto = Mapper.Map<SubjectViewModel, SubjectDto>(model);

                subjectService.UpdateSuject(subjectDto);

                TempData["Message"] = $"Subject {model.Name} " +
                                      "was succesfully edited";

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var subjectDto = subjectService.GetSubjectById(id);
            var subject = Mapper.Map<SubjectDto, SubjectViewModel>(subjectDto);

            return View(subject);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            subjectService.DeleteSubject(id);

            TempData["Message"] = $"Subject {id.Value} was succesfully deleted";

            return RedirectToAction("Index");
        }
    }
}