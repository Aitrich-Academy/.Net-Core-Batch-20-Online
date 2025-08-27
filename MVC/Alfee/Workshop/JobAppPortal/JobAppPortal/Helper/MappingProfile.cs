using AutoMapper;
using JobAppPortal.Dtos;
using JobAppPortal.Models;

namespace JobAppPortal.Helper
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
