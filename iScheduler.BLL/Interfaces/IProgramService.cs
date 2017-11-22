using System.Collections.Generic;
using iScheduler.BLL.DTO;

namespace iScheduler.BLL.Interfaces
{
    public interface IProgramService : IBaseService
    {
        IEnumerable<ProgramDto> GetProgramsByClass(int? classId);
        ProgramDto GetProgramById(int? programId);

        void CreateProgram(ProgramDto programDto);
        void DeleteProgram(int? programId);
        void UpdateProgram(ProgramDto programDto);
    }
}