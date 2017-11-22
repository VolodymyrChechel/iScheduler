using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.BLL.Interfaces;
using iScheduler.BLL.Services;
using iScheduler.WEB.Filters;
using iScheduler.WEB.Models;
using iScheduler.WEB.Util;

namespace iScheduler.WEB.Controllers
{
    [ExceptionFilter]
    public class CurriculumController : Controller
    {
        private IProgramService programService;

        public CurriculumController(IProgramService service)
        {
            programService = service;
        }

        [MessageFromTempData]
        public ActionResult Index()
        {
            var programsDtoList = programService.GetAllPrograms();
            var programsList = Mapper.Map<IEnumerable<ProgramDto>,
                IEnumerable<ProgramViewModel>>(programsDtoList);
            
            return View(programsList);
        }

        [HttpGet, CreateProgramData]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, CreateProgramData]
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

        [HttpGet, CreateProgramData]
        public ActionResult Edit(int? id)
        {
            var programDto = programService.GetProgramById(id);
            var program = Mapper.Map<ProgramDto, ProgramViewModel>(programDto);

            return View(program);
        }

        [HttpPost, CreateProgramData]
        public ActionResult Edit(ProgramViewModel model)
        {
            if (ModelState.IsValid)
            {
                var programDto = Mapper.Map<ProgramViewModel, ProgramDto>(model);
                programService.UpdateProgram(programDto);

                TempData["Message"] = $"Program for {model.ClassName} with {model.SubjectName}" +
                                   $" in {model.SemesterName} was succesfully updated";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var programDto = programService.GetProgramById(id);
            var program = Mapper.Map<ProgramDto, ProgramViewModel>(programDto);

            return View(program);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            programService.DeleteProgram(id);

            TempData["Message"] = $"Subject {id.Value} was succesfully deleted";

            return RedirectToAction("Index");
        }
    }
}