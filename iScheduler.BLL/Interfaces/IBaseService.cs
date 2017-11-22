using System.Collections.Generic;
using iScheduler.BLL.DTO;

namespace iScheduler.BLL.Interfaces
{
    public interface IBaseService
    {
        IEnumerable<ClassDto> GetAllClasses();
        IEnumerable<ProgramDto> GetAllPrograms();
        IEnumerable<SubjectDto> GetAllSubjects();
        IEnumerable<TeacherDto> GetAllTeachers();
        IEnumerable<SemesterDto> GetAllSemesters();
    }
}