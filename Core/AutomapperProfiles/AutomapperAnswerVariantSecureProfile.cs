using AutoMapper;
using BLL.DTO;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.AutomapperProfiles
{
    public class AutomapperAnswerVariantSecureProfile: Profile
    {
 
            public AutomapperAnswerVariantSecureProfile()
            {
                CreateMap<AnswerVariantDTO, AnswerVariantSecureModel>();
                CreateMap<AnswerVariantSecureModel, AnswerVariantDTO>();
            }
    }
}
