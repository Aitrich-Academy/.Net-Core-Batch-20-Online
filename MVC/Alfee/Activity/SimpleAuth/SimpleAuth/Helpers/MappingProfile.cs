using AutoMapper;
using SimpleAuth.Dto;
using SimpleAuth.Models;

namespace SimpleAuth.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UseDto>().ReverseMap();
        }
    }
}
