using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.BLL.Interfaces;
using iScheduler.DAL.Entities;
using iScheduler.DAL.Interfaces;

namespace iScheduler.BLL.Services
{
    public abstract class BaseService : IBaseService
    {
        protected IUnitOfWork db { get; set; }

        protected BaseService(IUnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<ClassDto> GetAllClasses()
        {
            var classesList = db.Classes.GetAll();

            var classesDtoList = Mapper.Map<IEnumerable<Class>,
                IEnumerable<ClassDto>>(classesList);

            return classesDtoList;
        }

        public IEnumerable<ProgramDto> GetAllPrograms()
        {
            // force using include
            var programsList = db.Programs.GetAll().ToList();

            //foreach (var program in programsList)
            //{
            //    program.Class = db.Classes.Find(program)
            //}


            var programsListDto = Mapper.Map<IEnumerable<Program>,
                IEnumerable<ProgramDto>>(programsList);

            return programsListDto;
        }

        public IEnumerable<SubjectDto> GetAllSubjects()
        {
            var subjectsList = db.Subjects.GetAll();

            var subjectsDtoList = Mapper.Map<IEnumerable<Subject>,
                IEnumerable<SubjectDto>>(subjectsList);

            return subjectsDtoList;
        }

        public IEnumerable<TeacherDto> GetAllTeachers()
        {
            var teachersList = db.Teachers.GetAll();
            var teachersDtoList = Mapper.Map<IEnumerable<Teacher>,
                IEnumerable<TeacherDto>>(teachersList);

            return teachersDtoList;
        }

        public IEnumerable<SemesterDto> GetAllSemesters()
        {
            var semestersList = db.Semesters.GetAll();
            var semestersDtoList = Mapper.Map<IEnumerable<Semester>,
                IEnumerable<SemesterDto>>(semestersList);

            return semestersDtoList;
        }
    }
}