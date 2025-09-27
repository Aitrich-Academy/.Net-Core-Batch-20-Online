using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Login.DTOs;
using Domain.Service.Profile.DTOs;
using HireMeNow_API_Admin.API.Admin.RequestObjects;
using HireMeNow_WebApi.API.Admin.RequestObjects;

namespace Domain.Extension
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles()
        {


            

            CreateMap<AuthUser, SystemUser>().ReverseMap();
 

            CreateMap<AuthUser, AdminLoginDTO>();

            CreateMap<Domain.Models.JobSeeker, JobSeekerDto>().ReverseMap();

            CreateMap<SkillRequest, SkillDto>();
            CreateMap<SkillDto, Skill>();
            CreateMap<Skill, SkillDto>();

            CreateMap<LocationRequest, LocationDto>();
            CreateMap<LocationDto, Location>();
            CreateMap<Location, LocationDto>();

            CreateMap<JobProviderCompany, Domain.Service.Admin.DTOs.JobProviderDto>().ReverseMap();

            CreateMap<JobPost, Joblist>().ReverseMap();

            CreateMap<Domain.Models.CompanyUser, Domain.Service.Admin.DTOs.CompanyUserDto>().ReverseMap();

            CreateMap<CompanyUserRequest , CompanyUserDto>();
            CreateMap<JobSeekerRequest, JobSeekerDto>();

        }
    }
}
