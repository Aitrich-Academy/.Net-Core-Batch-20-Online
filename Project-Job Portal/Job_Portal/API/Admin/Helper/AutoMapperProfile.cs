using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.DTOs;
//using Domain.Service.Login.DTOs;
using Domain.Service.Profile.DTOs;
using Job_Portal.API.Admin.Request_Objects;

namespace Job_Portal.API.Admin.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SkillRequest, SkillDto>();
            CreateMap<SkillDto, Skill>();
            CreateMap<SkillPatchRequest, SkillDto>().ReverseMap();
            CreateMap<Skill, SkillDto>().ReverseMap();
            CreateMap<LocationPatchRequest, LocationDto>();
            CreateMap<LocationDto, Location>();
            //CreateMap<AuthUser, AdminLoginDTO>().ReverseMap();

            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<LocationRequest, LocationDto>().ReverseMap();



        }
    }
}
