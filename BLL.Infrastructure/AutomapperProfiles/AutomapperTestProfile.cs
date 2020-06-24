using AutoMapper;
using DAL.Domain.Entities;
using BLL.DTO;


namespace BLL.Infrastructure.AutomapperProfiles
{
    public class AutomapperTestProfile : Profile
    {
        public AutomapperTestProfile()
        {
            CreateMap<TestDTO, Test>();
            CreateMap<Test, TestDTO>();
        }
    }
}
