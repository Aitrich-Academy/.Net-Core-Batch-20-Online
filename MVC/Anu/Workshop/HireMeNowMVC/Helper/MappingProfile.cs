using AutoMapper;
using HireMeNowMVC.Dto;
using HireMeNowMVC.Models;

namespace HireMeNowMVC.Helper
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<JobDto, Job>().ReverseMap();

            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<CompanyMemberDto, User>().ReverseMap();
        }
    }
}
