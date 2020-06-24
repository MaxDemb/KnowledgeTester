using System;
using System.Collections.Generic;
using System.Text;
using DAL.Domain.Entities;
using BLL.DTO;
using AutoMapper;

namespace BLL.Infrastructure.AutomapperProfiles
{
   public class AutomapperStudentProfile : Profile
    {
        public AutomapperStudentProfile()
        {
            CreateMap<StudentDTO, Student>();
            CreateMap<Student, StudentDTO>();
        }
    }
}
