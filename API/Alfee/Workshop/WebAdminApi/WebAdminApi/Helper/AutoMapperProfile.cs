using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.Dto;
using Domain.Service.Login.Dto;
using Domain.Service.Profile.Dto;
using WebAdminApi.API.Admin.RequestObjects;
namespace Domain.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SignUpRequest, SystemUser>().ReverseMap();
            CreateMap<AuthUser, Domain.Models.JobSeeker>().ReverseMap();
            CreateMap<AuthUser, SystemUser>().ReverseMap();
            CreateMap<AuthUser, Domain.Models.CompanyUser>().ReverseMap();
            CreateMap<AuthUser, AdminLoginDto>();

            CreateMap<Skill, SkillDto>();
            CreateMap<SkillRequest, SkillDto>();
            CreateMap<SkillDto, Skill>();

            CreateMap<Domain.Models.JobSeeker, JobSeekerDto>().ReverseMap();
            CreateMap<JobProviderCompany, Domain.Service.Admin.Dto.JobProviderDto>().ReverseMap();
            CreateMap<Location, LocationRequest>().ReverseMap();
            CreateMap<Location, LocationDto>().ReverseMap();                                                 
            CreateMap<JobPost, Domain.Service.Admin.Dto.JobProviderDto>().ReverseMap();
            CreateMap<JobPost, Domain.Service.Admin.Dto.Joblist>().ReverseMap();


        }
    }
}
