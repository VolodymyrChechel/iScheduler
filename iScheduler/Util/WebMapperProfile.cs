using AutoMapper;
using iScheduler.BLL.DTO;
using iScheduler.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iScheduler.WEB.Util
{
    public class WebMapperProfile : Profile 
    {
        public WebMapperProfile()
        {
            CreateMap<ClassDto, ClassViewModel>();
        }
    }
}