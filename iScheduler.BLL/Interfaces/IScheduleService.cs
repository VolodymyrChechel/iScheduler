using iScheduler.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iScheduler.BLL.Interfaces
{
    public interface IScheduleService : IBaseService
    {
        ClassDto GetClassById(int? classId);
        ClassDto GetClassByName(string className);

        IEnumerable<ClassDto> GetClassesByYear(int? yearId);
        IEnumerable<ClassDto> GetClassesByFormTeacher(string name);

        void CreateClass(ClassDto classDto);
        void DeleteClass(int? classId);
        void UpdateClass(ClassDto classDto);
    }
}
