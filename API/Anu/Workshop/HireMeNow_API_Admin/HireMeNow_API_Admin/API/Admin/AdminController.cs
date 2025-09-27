using AutoMapper;

using Domain.Service.Admin.Interfaces;

using Domain.Service.Job.Interfaces;
using Domain.Service.Login.Interfaces;

using HireMeNow_API_Admin.Controllers;
using Domain.Service.Profile.DTOs;

using Microsoft.AspNetCore.Mvc;
using HireMeNow_API_Admin.API.Admin.RequestObjects;
using Domain.Service.Admin.DTOs;
using HireMeNow_WebApi.API.Admin.RequestObjects;
using Domain.Models;
using Domain.Service.Job;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Runtime.ConstrainedExecution;

namespace HireMeNow_API_Admin.API.Admin
{
    // [Route("api/[controller]")]
    [ApiController]
    public class AdminController : BaseApiController<AdminController>
    {
        private readonly IAdminService _adminService;
        private readonly IMapper _mapper;
        IAdminRepository _adminRepository;
        private IMapper mapper;
        public ILoginRequestService _loginRequestService;
        IJobService _jobService;

        public AdminController(IMapper mapper, IAdminService adminService, IAdminRepository adminRepostory, ILoginRequestService loginRequestService, IJobService jobServices)
        {
            _mapper = mapper;
            _adminService = adminService;
            _adminRepository = adminRepostory;
            _loginRequestService = loginRequestService;
            _jobService = jobServices;
        }


        [HttpPost]
        [Route("Admin/login")]
        public async Task<ActionResult> Login(AdminLoginRequests logdata)
        {

            var user = _loginRequestService.Adminlogin(logdata.Email, logdata.Password);

            if (user == null)
            {
                return BadRequest("Login Failed");
            }
            return Ok(user);
        }

        [HttpGet]
        [Route("admin/GetJobSeekers")]
        public async Task<IActionResult> GetJobSeekers()
        {

            try
            {
                var jobSeekers = await _adminService.GetJobSeekers();
                return Ok(_mapper.Map<List<JobSeekerDto>>(jobSeekers));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        [HttpPost("skillAdd")]
        public async Task<IActionResult> AddSkill(SkillRequest skill)
        {
            // Map the request to DTO

            var Skill = _mapper.Map<SkillDto>(skill);

            // Call the service
            var result = await _adminService.AddSkillAsync(Skill);

            if (result)
            {
                return Ok("Skill added successfully");
            }
            else
            {
                return BadRequest("Skill already exists");
            }
        }


        [HttpDelete("skillRemove/{skillId}")]
        public async Task<IActionResult> RemoveSkill(Guid skillId)
        {
            // Call the service
            var result = await _adminService.RemoveSkillAsync(skillId);

            if (result)
            {
                return Ok("Skill deleted successfully");
            }
            else
            {
                return NotFound("Skill not found or failed to delete");
            }
        }


        [HttpGet]
        [Route("admin/GetCompanies")]
        public async Task<IActionResult> GetCompanies()
        {

            try
            {
                var jobProviders = await _adminService.GetCompanies();
                return Ok(_mapper.Map<List<JobProviderDto>>(jobProviders));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPost("AddLocation")]
        public async Task<IActionResult> AddLocation(LocationRequest location)
        {
            var Location = _mapper.Map<LocationDto>(location);
            var result = await _adminService.AddLocationAsync(Location);

            if (result)
            {
                return Ok("Location added successfully");
            }
            else
            {
                return BadRequest("Location already exists");
            }


        }

        [HttpGet]
        [Route("admin/SearchCompanies")]
        public async Task<IActionResult> SearchCompanies(string name)
        {

            try
            {

                var companies = await _adminService.SearchCompanies(name);
                return Ok(_mapper.Map<List<JobProviderDto>>(companies));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }


        [HttpGet]
        [Route("alljobs")]
        public async Task<IActionResult> alljobs()
        {

            try
            {
                var jobs = await _adminService.GetJobs();
                return Ok(_mapper.Map<List<Joblist>>(jobs));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("admin/jobsbyName")]
        public async Task<IActionResult> getalljobs(string Title)
        {

            try
            {
                var jobs = await _adminService.GetJobs(Title);
                return Ok(_mapper.Map<List<Joblist>>(jobs));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("admin/RemoveCompanyUsers/{id}")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                _adminService.DeleteById(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("admin/GetJobProviderCount")]
        public IActionResult GetJobProviderCount()
        {
            try
            {
                var count = _adminService.GetJobProviderCount();
                return Ok(new { Count = count });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("admin/GetJobCount")]
        public IActionResult GetJobCount()
        {
            try
            {
                var count = _adminService.GetJobCount();
                return Ok(new { Count = count });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet("GetLocations")]
        public async Task<IActionResult> GetLocations()
        {

            try
            {
                var locations = await _adminService.GetLocations();
                return Ok(_mapper.Map<List<LocationDto>>(locations));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete]
        [Route("RemoveLocations/{id}")]
        public IActionResult RemoveLocation(Guid id)
        {
            try
            {
                _adminService.DeleteByLocationId(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("GetJobProviderCompantById/{id}")]
        public async Task<IActionResult> GetProviderCompanyById(Guid id)
        {
            var jobProvidercomapntByid = await _adminService.GetProvidercompanyByIdAsync(id);
            if (jobProvidercomapntByid == null) return NotFound();
            return Ok(jobProvidercomapntByid);
        }


        [HttpPut]
        [Route("GetUpdateCompanyUser/{id}")]
        public async Task<IActionResult> UpdateJob(Guid id, CompanyUserRequest company )  
        {
             
            var Cuser= _mapper.Map<CompanyUserDto>(company);

            if (id != Cuser.Id) return NotFound();
            var updatecompanyuser = await _adminService.UpdatecompanyUserAsync(Cuser);
            return Ok(updatecompanyuser);
        }

        [HttpPatch("PatchSkill/{id}")]
        public async Task<ActionResult> PatchSkill(Guid id, SkillRequest  skillpatch)
        {
            var skilldto=_mapper.Map <SkillDto>(skillpatch);
            var result = await _adminService.PatchSkillAsync(skilldto);
             if (result)
                return Ok("Skill Partially Upadated");
            else 
                return NotFound("Skill not found");
        }


        [HttpPatch("PatchJobSeeker/{id}")]
        public async Task<ActionResult> PatchJobSeeker(Guid id, JobSeekerRequest seekerpatch)
        {
            var seekerdto = _mapper.Map<JobSeekerDto>(seekerpatch);
            var result = await _adminService.PatchSeekerAsync(seekerdto);
            if (result)
                return Ok("Seeker Partially Upadated");
            else
                return NotFound("Seeker not found");
        }



    }
}
