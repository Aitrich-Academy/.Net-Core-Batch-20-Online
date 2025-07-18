using AutoMapper;
using CompanyManagement.Model;
using CompanyManagement.Dto;

namespace CompanyManagement.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<CompanyMember, CompanyMemberDto>().ReverseMap();
        }
    }
}