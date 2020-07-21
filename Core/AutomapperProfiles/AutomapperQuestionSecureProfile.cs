using AutoMapper;
using BLL.DTO;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.AutomapperProfiles
{
    public class AutomapperQuestionSecureProfile : Profile
    {
            public AutomapperQuestionSecureProfile()
            {
                CreateMap<QuestionDTO, QuestionSecureModel>();
                CreateMap<QuestionSecureModel, QuestionDTO>();
            }
    }
}
