using iScheduler.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iScheduler.DAL.Entities;

namespace iScheduler.BLL.Interfaces
{
    public interface ISubjectService : IBaseService
    {
        SubjectDto GetSubjectById(int? subjectId);
        SubjectDto GetSubjectByName(string subjectName);

        void CreateSubject(SubjectDto subjectDto);
        void DeleteSubject(int? subjectId);
        void UpdateSuject(SubjectDto subjectDto);
    }
}
