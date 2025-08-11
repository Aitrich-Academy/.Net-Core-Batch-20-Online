using AutoMapper;
using JobPortalMVC.Dto;
using JobPortalMVC.Models;

namespace JobPortalMVC.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
