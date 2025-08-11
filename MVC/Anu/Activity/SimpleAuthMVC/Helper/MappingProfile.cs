using AutoMapper;
using SimpleAuthMVC.Dto;
using SimpleAuthMVC.Models;

namespace SimpleAuthMVC.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
