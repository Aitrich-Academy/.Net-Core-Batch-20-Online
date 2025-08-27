using AutoMapper;
using JobApi.Model;
using JobApi.Models;
using JobPortalAPI.DTOs;

namespace JobApi.Help
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Job, JobDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();

        }
    }
}
