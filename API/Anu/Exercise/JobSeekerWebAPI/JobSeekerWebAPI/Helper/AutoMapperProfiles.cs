using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.Job.DTO;
using Domain.Service.JobSeeker.DTO;
using Domain.Service.Login.DTO;
using Domain.Service.User.DTO;
using JobSeekerWebAPI.API.Job.RequestObject;
using JobSeekerWebAPI.API.JobSeeker.RequestObject;
using JobSeekerWebAPI.API.User.RequestObject;

namespace Domain.Extension
{
    public class AutoMapperProfiles :Profile
    {
        public AutoMapperProfiles()
        { 
            CreateMap<RegisterRequest, RegisterUserDto>();
            CreateMap<RegisterUserDto, RegisterUser>();
            CreateMap<RegisterUser, RegisterUserDto>();

            CreateMap<LoginRequest, UserLoginDto>();
            CreateMap<UserLoginDto, RegisterUser>();
            CreateMap<RegisterUser, UserLoginDto>();

            CreateMap<SeekerUpdateRequest, SeekerDto>();
            CreateMap<SeekerDto, RegisterUser>();
            CreateMap<RegisterUser, SeekerDto>();

            CreateMap<JobPost, Joblist>().ReverseMap();

            CreateMap<AppliedJobRequest, AppliedJobDto>();
            CreateMap<AppliedJobDto, AppliedJobs>();
            CreateMap<AppliedJobs, AppliedJobDto>();
        }
    }
}
