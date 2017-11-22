using System.Collections.Generic;
using iScheduler.BLL.DTO;

namespace iScheduler.BLL.Interfaces
{
    public interface ITeacherService : IBaseService
    {
        TeacherDto GetTeacherById(int? teacherId);
        
        IEnumerable<TeacherDto> GetTeachersByYear(int? yearId);

        void CreateTeacher(TeacherDto teacherDto);
        void DeleteTeacher(int? classId);
        void UpdateTeacher(TeacherDto teacherDto);
    }
}