using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.JobProvider.DTOs;
using Domain.Service.Login.DTOs;
using Job_Portal.API.Admin.Request_Objects;

namespace Job_Portal.API.Admin.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AuthUser, AdminLoginDTO>().ReverseMap();
            CreateMap<SystemUser, AdminLoginDTO>().ReverseMap();

            CreateMap<AdminLoginRequests, AdminLoginDTO>().ReverseMap();
            CreateMap<AdminLoginDTO, AuthUser>().ReverseMap();


            CreateMap<IndustryObjectDto, Industry>().ReverseMap();


            CreateMap<Industry, IndustryDto>().ReverseMap();
            CreateMap<IndustryObjectDto, IndustryDto>().ReverseMap();
            CreateMap<Industry, IndustryDto>().ReverseMap();
            CreateMap<Industry, PatchIndustryDto>().ReverseMap();
            CreateMap<IndustryDto, PatchIndustryDto>().ReverseMap();



            CreateMap<JobPost, JobDto>().ReverseMap();


            CreateMap<CreateJobCategoryDto, JobCategoryDto>().ReverseMap();
            CreateMap<JobCategoryDto, JobCategory>().ReverseMap();
            // From API Patch DTO -> Domain Patch DTO
            CreateMap<PatchJobCategoryDto, PatchJobCategoryDTO>().ReverseMap();

            // From Domain Patch DTO -> JobCategory (entity)
            CreateMap<PatchJobCategoryDTO, JobCategory>().ReverseMap();



            //CreateMap<JobProviderRequestDto, JobProviderDto>().ReverseMap();
            //CreateMap<JobProviderDto, JobProviderCompany>().ReverseMap();
            //CreateMap<JobProviderCompany, JobProviderRequestDto>().ReverseMap();

            CreateMap<JobProviderCompany, JobProviderDto>().ReverseMap();
            CreateMap<JobProviderCompany, JobProviderRequestDto>().ReverseMap();
            CreateMap<JobProviderDto, JobProviderRequestDto>().ReverseMap();


        }

    }
}
