using AutoMapper;
using JobApp.Dto;
using JobApp.Model;

namespace JobApp.Helper
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
