using AutoMapper;
using UserManagement.Dto;
using UserManagement.Models;

namespace UserManagement.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }

    }
}
