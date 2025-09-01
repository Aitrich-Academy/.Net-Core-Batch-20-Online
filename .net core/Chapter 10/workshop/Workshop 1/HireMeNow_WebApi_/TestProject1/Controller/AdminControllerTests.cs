using AutoMapper;
using Domain.Service.Admin.DTOs;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Job.Interfaces;
using Domain.Service.Login.Interfaces;
using HireMeNow_WebApi.API.Admin;
using HireMeNow_WebApi.Extensions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1.Controller
{
    public class AdminControllerTests
    {
        private readonly Mock<IAdminServices> _adminService;
        private readonly IMapper _mapper;
        public readonly Mock<IAdminRepository> _adminRepository;
        public readonly Mock<ILoginRequestService> _loginRequestService;
        public readonly Mock<IJobServices> _jobService;
        private readonly AdminController _controller;
       
       
        public AdminControllerTests()
        {
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfiles>();
            });
            
        }
        [Fact]
        public void GetCompanies()
        {
            var companies=new JobProviderDto
            {

                i
            } 
        }


    }
}
