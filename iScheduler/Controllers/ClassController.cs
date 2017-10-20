using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.BLL.Interfaces;
using iScheduler.WEB.Filters;
using iScheduler.WEB.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace iScheduler.WEB.Controllers
{
    [ExceptionFilter]
    public class ClassController : Controller
    {
        readonly IClassService classService;

        public ClassController(IClassService service)
        {
            classService = service;
        }

        public ActionResult Index()
        {
            var classesDtoList = classService.GetAllClasses();

            var classesList = AutoMapper.Mapper.
                Map<IEnumerable<ClassDto>, IEnumerable<ClassViewModel>>
                (classesDtoList);

          //  if (TempData["Message"] != null)
                ViewBag.Message = TempData["Message"];

            return View(classesList);
        }

        //[ExceptionFilter]
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            //try
            //{
                var classDto = classService.GetClassById(id);
                var classObj = Mapper.Map<ClassDto, ClassViewModel>(classDto);

                return View(classObj);
            //}
            //catch (ValidationException e)
            //{
               
            //}
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClassViewModel model)
        {
            if(ModelState.IsValid)
            {
                var classDto = Mapper.Map<ClassViewModel, ClassDto>(model);
                classService.UpdateClass(classDto);

                TempData["Message"] = $"Class \"{model.Name}\" was updated";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClassViewModel model)
        {
            if (ModelState.IsValid)
            {
                var classDto = Mapper.Map<ClassViewModel, ClassDto>(model);
                classService.CreateClass(classDto);

                TempData["Message"] = $"Class \"{model.Name}\" was successfully created";

                return RedirectToAction("Index");
            }
            
            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var classDto = classService.GetClassById(id);
            var classObj = Mapper.Map<ClassDto, ClassViewModel>(classDto);

            return View(classObj);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            classService.DeleteClass(id);

            TempData["Message"] = $"Class id={id.Value} was successfully deleted";
            return RedirectToAction("Index");
        }
    }
}
