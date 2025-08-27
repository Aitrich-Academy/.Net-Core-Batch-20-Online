using AutoMapper;
using JobSeekerPortal.Dtos;
using JobSeekerPortal.Models;

namespace JobSeekerPortal.Helper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // User <-> UserDto
            CreateMap<User, UserDto>().ReverseMap();

            // Job <-> JobDto
            CreateMap<Job, JobDto>().ReverseMap();

            // Application <-> ApplicationDto
            CreateMap<Application, ApplicationDto>().ReverseMap();
        }
    }
}
