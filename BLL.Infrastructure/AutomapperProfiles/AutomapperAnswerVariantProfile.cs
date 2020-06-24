using BLL.DTO;
using DAL.Domain.Entities;
using AutoMapper;

namespace BLL.Infrastructure.AutomapperProfiles
{
    public class AutomapperAnswerVariantProfile : Profile
    {
        public AutomapperAnswerVariantProfile()
        {
            CreateMap<AnswerVariantDTO, AnswerVariant>();
            CreateMap<AnswerVariant, AnswerVariantDTO>();
        }
    }
}
