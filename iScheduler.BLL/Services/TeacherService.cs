using System.Collections.Generic;
using iScheduler.BLL.DTO;
using iScheduler.BLL.Interfaces;

namespace iScheduler.BLL.Services
{
    public class TeacherService : ITeacher
    {
        public TeacherDto GetTeacherById(int? teacherId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TeacherDto> GetTeachersByYear(int? yearId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TeacherDto> GetAllTeacher()
        {
            throw new System.NotImplementedException();
        }

        public void CreateTeacher(TeacherDto teacherDto)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTeacher(int? classId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateTeacher(TeacherDto teacherDto)
        {
            throw new System.NotImplementedException();
        }
    }
}