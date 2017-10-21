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
    public class TeacherController : Controller
    {
        private readonly ITeacherService teacherService;

        public TeacherController(ITeacherService service)
        {
            teacherService = service;
        }

        public ActionResult Index()
        {
            var teachersDtoList = teacherService.GetAllTeachers();
            var teachersList = Mapper.Map<IEnumerable<TeacherDto>,
                IEnumerable<TeacherViewModel>>(teachersDtoList);

            ViewBag.Message = TempData["Message"];
            return View(teachersList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                var teacherDto = Mapper.Map<TeacherViewModel, TeacherDto>(model);
                teacherService.CreateTeacher(teacherDto);

                TempData["Message"] = $"Teacher {model.Surname} {model.Name}" +
                    $" {model.Patronymic} was succesfully created";

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var teacherDto = teacherService.GetTeacherById(id);
            var teacher = Mapper.Map<TeacherDto, TeacherViewModel>(teacherDto);

            return View(teacher);
        }

        [HttpPost]
        public ActionResult Edit(TeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                var teacherDto = Mapper.Map<TeacherViewModel, TeacherDto>(model);
                teacherService.CreateTeacher(teacherDto);

                TempData["Message"] = $"Teacher {model.Surname} {model.Name}" +
                                      $" {model.Patronymic} was succesfully edited";

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var teacherDto = teacherService.GetTeacherById(id);
            var teacher = Mapper.Map<TeacherDto, TeacherViewModel>(teacherDto);

            return View(teacher);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            teacherService.DeleteTeacher(id);

            TempData["Message"] = $"Teacher {id.Value} was succesfully deleted";

            return RedirectToAction("Index");
        }
    }
}