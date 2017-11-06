using System.Collections.Generic;
using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.BLL.Infrastructure;
using iScheduler.BLL.Interfaces;
using iScheduler.DAL.Entities;
using iScheduler.DAL.Interfaces;

namespace iScheduler.BLL.Services
{
    public class ProgramService : IProgramService
    {
        private IUnitOfWork db { get; set; }

        public ProgramService(IUnitOfWork uow)
        {
            db = uow;
        }

        public IEnumerable<ProgramDto> GetAllPrograms()
        {
            var programsList = db.Programs.GetAll();

            var programsListDto = Mapper.Map<IEnumerable<Program>,
                IEnumerable<ProgramDto>>(programsList);

            return programsListDto;
        }

        public IEnumerable<ProgramDto> GetProgramsByClass(int? classId)
        {
            throw new System.NotImplementedException();
        }


        public void CreateProgram(ProgramDto programDto)
        {
            if (programDto == null)
                throw new ValidationException("Object of program is null", "");

            var programObj = AutoMapper.Mapper.Map<ProgramDto, Program>(programDto);

            db.Programs.Create(programObj);
            db.Save();
        }

        public void DeleteProgram(int? programId)
        {
            if (programId == null)
                throw new ValidationException("Program id was not passed", "");

            var programObj = db.Programs.Get(programId.Value);

            if (programObj == null)
                throw new ValidationException("Program was not found", "");

            db.Programs.Delete(programObj.Id);
            db.Save();
        }

        public void UpdateProgram(ProgramDto programDto)
        {
            if (programDto == null)
                throw new ValidationException("Object of program is null", "");

            var programObj = AutoMapper.Mapper.Map<ProgramDto, Program>(programDto);

            db.Programs.Update(programObj);
            db.Save();
        }

        public IEnumerable<ClassDto> GetAllClasses()
        {
            var classesList = db.Classes.GetAll();

            var classesDtoList = Mapper.Map<IEnumerable<Class>, IEnumerable<ClassDto>>(classesList);

            return classesDtoList;
        }
    }
}