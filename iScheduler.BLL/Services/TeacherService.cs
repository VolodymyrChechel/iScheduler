using System.Collections.Generic;
using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.BLL.Infrastructure;
using iScheduler.BLL.Interfaces;
using iScheduler.DAL.Entities;
using iScheduler.DAL.Interfaces;

namespace iScheduler.BLL.Services
{
    public class TeacherService : BaseService, ITeacherService
    {
        public TeacherService(IUnitOfWork uow) : base(uow) { }

        public TeacherDto GetTeacherById(int? teacherId)
        {
            if (teacherId == null)
                throw new ValidationException("Teacher id was not found","");

            var teacher = db.Teachers.Get(teacherId.Value);

            if (teacher == null)
                throw new ValidationException("Teacher object was not found", "");

            var teacherDto = Mapper.Map<Teacher, TeacherDto>(teacher);
            return teacherDto;
        }

        public IEnumerable<TeacherDto> GetTeachersByYear(int? yearId)
        {
            throw new System.NotImplementedException();
        }

        public void CreateTeacher(TeacherDto teacherDto)
        {
            if (teacherDto == null)
                throw new ValidationException("Object of class is null", "");

            var teacherObj = AutoMapper.Mapper.Map<TeacherDto, Teacher>(teacherDto);

            db.Teachers.Create(teacherObj);
            db.Save();
        }

        public void DeleteTeacher(int? teacherId)
        {
            if (teacherId == null)
                throw new ValidationException("Teacher id was not passed", "");

            var teacher = db.Teachers.Get(teacherId.Value);

            if (teacher == null)
                throw new ValidationException("Teacher was not found", "");

            db.Teachers.Delete(teacher.Id);
            db.Save();
        }

        public void UpdateTeacher(TeacherDto teacherDto)
        {
            if (teacherDto == null)
                throw new ValidationException("Object of class is null", "");

            var teacherObj = AutoMapper.Mapper.Map<TeacherDto, Teacher>(teacherDto);

            db.Teachers.Update(teacherObj);
            db.Save();
        }
    }
}