using System.Collections.Generic;
using iScheduler.BLL.DTO;

namespace iScheduler.BLL.Interfaces
{
    public interface ITeacherService
    {
        TeacherDto GetTeacherById(int? teacherId);
        
        IEnumerable<TeacherDto> GetTeachersByYear(int? yearId);
        IEnumerable<TeacherDto> GetAllTeachers();

        void CreateTeacher(TeacherDto teacherDto);
        void DeleteTeacher(int? classId);
        void UpdateTeacher(TeacherDto teacherDto);
    }
}