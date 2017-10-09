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

namespace iScheduler.BLL.Services
{
    public class ClassService : IClassService
    {
        private SchoolContext db { get; set; }

        public ClassService(SchoolContext context)
        {
            db = context;
        }

        public void CreateClass(ClassDto classDto)
        {
            var repo = new GenericRepository<SchoolContext, Class>(db);
            throw new NotImplementedException();
        }

        public void DeleteClass(int? classId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClassDto> GetAllClasses()
        {
            throw new NotImplementedException();
        }

        public ClassDto GetClassById(int? classId)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
