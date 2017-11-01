using iScheduler.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iScheduler.DAL.Entities;

namespace iScheduler.BLL.Interfaces
{
    public interface ISubjectService
    {
        SubjectDto GetSubjectById(int? subjectId);
        SubjectDto GetSubjectByName(string subjectName);
        IEnumerable<SubjectDto> GetAllSubjects();

        void CreateSubject(SubjectDto subjectDto);
        void DeleteSubject(int? subjectId);
        void UpdateSuject(SubjectDto subjectDto);

    }
}
