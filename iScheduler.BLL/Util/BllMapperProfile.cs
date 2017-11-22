using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.DAL.Entities;

namespace iScheduler.BLL.Util
{
    public class BllMapperProfile : Profile
    {
        public BllMapperProfile()
        {
            CreateMap<Class, ClassDto>();
            CreateMap<ClassDto, Class>();

            CreateMap<Teacher, TeacherDto>();
            CreateMap<TeacherDto, Teacher>();

            CreateMap<Subject, SubjectDto>();
            CreateMap<SubjectDto, Subject>();

            CreateMap<Program, ProgramDto>();
            CreateMap<ProgramDto, Program>();

            CreateMap<Semester, SemesterDto>();
            CreateMap<SemesterDto, Semester>();

            CreateMap<Schedule, ScheduleDto>();
            CreateMap<ScheduleDto, Schedule>();
        }
    }
}
