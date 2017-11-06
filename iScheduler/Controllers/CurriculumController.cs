using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.BLL.Interfaces;
using iScheduler.BLL.Services;
using iScheduler.DAL.Entities;
using iScheduler.WEB.Filters;
using iScheduler.WEB.Models;

namespace iScheduler.WEB.Controllers
{
    [ExceptionFilter]
    public class CurriculumController : Controller
    {
        public IProgramService programService;

        public CurriculumController(IProgramService service)
        {
            programService = service;
        }

        public ActionResult Index()
        {
            var programsDtoList = programService.GetAllPrograms();
            var programsList = Mapper.Map<IEnumerable<ProgramDto>,
                IEnumerable<ProgramViewModel>>(programsDtoList);

            ViewBag.Message = TempData["Message"];
            return View(programsList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var classDtos = 

            ViewBag.ClassesListItems = new SelectedList()
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProgramViewModel model)
        {
            if (ModelState.IsValid)
            {
                var programDto = Mapper.Map<ProgramViewModel, ProgramDto>(model);
                programService.CreateProgram(programDto);

                TempData["Message"] = $"Program for {model.ClassName} with {model.SubjectName}" +
                                   $" in {model.SemesterName} was succesfully created";
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}