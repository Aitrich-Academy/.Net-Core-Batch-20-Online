using AutoMapper;
using JobPortalAPI.Models;
using JobPortalAPI.DTO;

namespace JobPortalAPI.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
