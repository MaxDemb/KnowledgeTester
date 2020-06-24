using System;
using System.Collections.Generic;
using System.Text;
using DAL.Domain.Entities;
using BLL.DTO;
using AutoMapper;

namespace BLL.Infrastructure.AutomapperProfiles
{
    public class AutomapperTeacherProfile : Profile
    {
        public AutomapperTeacherProfile()
        {
            CreateMap<Teacher, TeacherDTO>();
            CreateMap<TeacherDTO, Teacher>();
        }
    }
}
