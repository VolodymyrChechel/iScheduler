using iScheduler.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iScheduler.BLL.DTO;
using iScheduler.DAL.EF;
using iScheduler.DAL.Entities;
using iScheduler.DAL.Repositories;
using iScheduler.DAL.Interfaces;
using iScheduler.BLL.Infrastructure;
using AutoMapper;

namespace iScheduler.BLL.Services
{
    public class ClassService : BaseService, IClassService
    {
        public ClassService(IUnitOfWork uow) : base(uow) { }

        public void CreateClass(ClassDto classDto)
        {
            if (classDto == null)
                throw new ValidationException("Object of class is null", "");

            var classObj = AutoMapper.Mapper.Map<ClassDto, Class>(classDto);

            db.Classes.Create(classObj);
            db.Save();
        }

        public void DeleteClass(int? classId)
        {
            if (classId == null)
                throw new ValidationException("Class id was not passed", "");

            var classObj = db.Classes.Get(classId.Value);

            if (classObj == null)
                throw new ValidationException("Class was not found", "");

            db.Classes.Delete(classObj.Id);
            db.Save();
        }

        public ClassDto GetClassById(int? classId)
        {
            if (classId == null)
                throw new ValidationException("Class id was not passed", "");

            var classObj = db.Classes.Get(classId.Value);

            if (classObj == null)
                throw new ValidationException("Class was not found", "");

            var classDto = Mapper.Map<Class, ClassDto>(classObj);

            return classDto;
        }

        public ClassDto GetClassByName(string className)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClassDto> GetClassesByFormTeacher(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClassDto> GetClassesByYear(int? yearId)
        {
            throw new NotImplementedException();
        }

        public void UpdateClass(ClassDto classDto)
        {
            if (classDto == null)
                throw new ValidationException("Object of class is null", "");

            var classObj = AutoMapper.Mapper.Map<ClassDto, Class>(classDto);

            db.Classes.Update(classObj);
            db.Save();
        }
    }
}
