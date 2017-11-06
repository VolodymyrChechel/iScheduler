using System.Collections.Generic;
using iScheduler.BLL.DTO;

namespace iScheduler.BLL.Interfaces
{
    public interface IProgramService
    {
        IEnumerable<ProgramDto> GetAllPrograms();
        IEnumerable<ProgramDto> GetProgramsByClass(int? classId);

        void CreateProgram(ProgramDto programDto);
        void DeleteProgram(int? programId);
        void UpdateProgram(ProgramDto programDto);

        // service methods
        IEnumerable<ClassDto> GetAllClasses();
    }
}