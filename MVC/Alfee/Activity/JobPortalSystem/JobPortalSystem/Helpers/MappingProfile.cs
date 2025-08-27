using AutoMapper;
using JobPortalSystem.Dto;
using JobPortalSystem.Models;

namespace JobPortalSystem.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Job , JobDto>().ReverseMap();
        }
    }
}
