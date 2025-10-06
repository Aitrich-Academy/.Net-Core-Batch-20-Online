using AutoMapper;
using Domain.Model;
using Domain.Service.Applicants.Dto;
using Domain.Service.Interviews.Dto;
using Domain.Service.JobProviders.Dto;
using Domain.Service.Profile.Dto;

namespace JobProviderApi.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Job Provider ↔ DTOs
            CreateMap<JobProviderRegisterDto, JobProvider>();
            CreateMap<JobProvider, JobProviderProfileDto>()
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.ToString()));

            // Applicant ↔ DTOs
            CreateMap<Applicant, ApplicantDto>();

            // Interview ↔ DTOs
            CreateMap<Interview, InterviewDto>().ReverseMap();
        }
    }
}
