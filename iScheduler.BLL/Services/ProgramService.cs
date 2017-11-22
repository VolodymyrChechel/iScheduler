using System.Collections.Generic;
using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.BLL.Infrastructure;
using iScheduler.BLL.Interfaces;
using iScheduler.DAL.Entities;
using iScheduler.DAL.Interfaces;

namespace iScheduler.BLL.Services
{
    public class ProgramService : BaseService, IProgramService
    {
        public ProgramService(IUnitOfWork uow) : base(uow) { }

        public IEnumerable<ProgramDto> GetProgramsByClass(int? classId)
        {
            throw new System.NotImplementedException();
        }

        public ProgramDto GetProgramById(int? programId)
        {
            if (programId == null)
                throw new ValidationException("Program id is null", "");

            var programObj = db.Programs.Get(programId.Value);

            if (programObj == null)
                throw new ValidationException("Program was not found", "");

            var programDto = AutoMapper.Mapper.Map<Program, ProgramDto>(programObj);
            return programDto;
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
    }
}