using System;
using System.Collections.Generic;
using System.Text;
using DAL.Domain.Entities;
using BLL.DTO;
using AutoMapper;

namespace BLL.Infrastructure.AutomapperProfiles
{
    public class AutomapperQuestionProfile : Profile
    {

        public AutomapperQuestionProfile()
        {
            CreateMap<QuestionDTO, Question>();
            CreateMap<Question, QuestionDTO>();
        }
    }
}
