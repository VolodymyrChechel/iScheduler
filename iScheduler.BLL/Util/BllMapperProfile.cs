﻿using AutoMapper;
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
        }
    }
}
