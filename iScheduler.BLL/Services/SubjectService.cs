using System.Collections.Generic;
using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.BLL.Infrastructure;
using iScheduler.BLL.Interfaces;
using iScheduler.DAL.Entities;
using iScheduler.DAL.Interfaces;

namespace iScheduler.BLL.Services
{
    public class SubjectService : BaseService, ISubjectService
    {
        public SubjectService(IUnitOfWork uow) : base(uow) { }

        public SubjectDto GetSubjectById(int? subjectId)
        {
            if (subjectId == null)
                throw new ValidationException("Teacher id was not found", "");

            var subject = db.Subjects.Get(subjectId.Value);

            if (subject == null)
                throw new ValidationException("Teacher object was not found", "");

            var subjectDto = Mapper.Map<Subject, SubjectDto>(subject);
            return subjectDto;
        }

        public SubjectDto GetSubjectByName(string subjectName)
        {
            throw new System.NotImplementedException();
        }

        public void CreateSubject(SubjectDto subjectDto)
        {
            if (subjectDto == null)
                throw new ValidationException("Object of subject is null", "");

            var subjectObj = AutoMapper.Mapper.Map<SubjectDto, Subject>(subjectDto);

            db.Subjects.Create(subjectObj);
            db.Save();
        }

        public void DeleteSubject(int? subjectId)
        {
            if (subjectId == null)
                throw new ValidationException("Subject id was not passed", "");

            var subjectObj = db.Subjects.Get(subjectId.Value);

            if (subjectObj == null)
                throw new ValidationException("Subject was not found", "");

            db.Subjects.Delete(subjectObj.Id);
            db.Save();
        }

        public void UpdateSuject(SubjectDto subjectDto)
        {
            if (subjectDto == null)
                throw new ValidationException("Object of subject is null", "");

            var subjectObj = AutoMapper.Mapper.Map<SubjectDto, Subject>(subjectDto);

            db.Subjects.Update(subjectObj);
            db.Save();
        }
    }
}