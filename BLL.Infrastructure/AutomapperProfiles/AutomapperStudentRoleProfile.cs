using AutoMapper;
using BLL.DTO;
using DAL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infrastructure.AutomapperProfiles
{
    public class AutomapperStudentRoleProfile : Profile
    {
        public AutomapperStudentRoleProfile()
        {
            CreateMap<StudentDTO, StudentRole>();
            CreateMap<StudentRole, StudentDTO>();
        }
    }
}
