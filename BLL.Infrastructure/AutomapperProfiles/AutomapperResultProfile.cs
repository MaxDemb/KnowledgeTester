using System;
using System.Collections.Generic;
using System.Text;
using DAL.Domain.Entities;
using BLL.DTO;
using AutoMapper;

namespace BLL.Infrastructure.AutomapperProfiles
{
    public class AutomapperResultProfile : Profile
    {
        public AutomapperResultProfile()
        {
            CreateMap<ResultDTO, Result>();
            CreateMap<Result, ResultDTO>();
        }
    }
}
