using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Login.Interfaces;
using Domain.Service.Profile.DTOs;
using Job_Portal.API.Admin.Request_Objects;
using Job_Portal.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Job_Portal.API.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        
        //    private readonly IAdminServices _adminService;
        //    private readonly IMapper _mapper;
        //    IAdminRepository _adminRepository;
        //    private IMapper mapper;
        //private readonly ILoginRequestService _loginRequestService;
           

            //public AdminController(IMapper mapper, IAdminServices adminService, IAdminRepository adminRepostory,ILoginRequestService loginRequestService)
            //{
            //    _mapper = mapper;
            //    _adminService = adminService;
            //    _adminRepository = adminRepostory;
            //_loginRequestService = loginRequestService;
             
            //}

        //[AllowAnonymous]
        //[HttpPost]
       

        //[Route("Admin/login")]

        //public ActionResult Login(AdminLoginRequests logdata)
        //{

        //    var user = _loginRequestService.Adminlogin(logdata.Email, logdata.Password);

        //    if (user == null)
        //    {
        //        return BadRequest("Login Failed");
        //    }

        //    return Ok(user);
        //}
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
        [HttpPut("skillUpdate/{skillId}")]
        public async Task<IActionResult> UpdateSkill(Guid skillId, SkillRequest skill)
        {
            var skillDto = _mapper.Map<SkillDto>(skill);
            var result = await _adminService.UpdateSkillAsync(skillId, skillDto);

            if (result) return Ok("Skill updated successfully");
            return NotFound("Skill not found or failed to update");
        }

        [HttpPatch("skillPatch/{skillId}")]
        public async Task<IActionResult> PatchSkill(Guid skillId, [FromBody] SkillPatchRequest skill)
        {
            var skillDto = _mapper.Map<SkillDto>(skill);
            var result = await _adminService.PatchSkillAsync(skillId, skillDto);

            if (result)
                return Ok("Skill partially updated successfully");
            else
                return NotFound("Skill not found or failed to update");
        }
        [HttpGet("getSkillById/{id}")]
        public async Task<IActionResult> GetSkillById(Guid id)
        {
            var skill = await _adminService.GetSkillByIdAsync(id);

            if (skill == null)
                return NotFound($"Skill with ID {id} not found");

            return Ok(skill);
        }


        [HttpGet("getAllSkills")]
        public async Task<IActionResult> GetAllSkills()
        {
            var skills = await _adminService.GetAllSkillsAsync();

            if (skills == null || !skills.Any())
                return NotFound("No skills found");

            return Ok(skills);
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
        [HttpPost("locationAdd")]
        public async Task<IActionResult> AddLocation(LocationRequest location)
        {
            var locationDto = _mapper.Map<LocationDto>(location);
            var result = await _adminService.AddLocationAsync(locationDto);

            if (result)
                return Ok("Location added successfully");
            else
                return BadRequest("Location already exists");
        }

        [HttpGet("getAllLocations")]
        public async Task<IActionResult> GetAllLocations()
        {
            var locations = await _adminService.GetAllLocationsAsync();

            if (locations == null || !locations.Any())
                return NotFound("No locations found.");

            return Ok(locations);
        }

        [HttpGet("getLocationById/{id}")]
        public async Task<IActionResult> GetLocationById(Guid id)
        {
            var location = await _adminService.GetLocationByIdAsync(id);

            if (location == null)
                return NotFound($"Location with ID {id} not found.");

            return Ok(location);
        }


        [HttpPut("locationUpdate/{locationId}")]
        public async Task<IActionResult> UpdateLocation(Guid locationId, LocationRequest location)
        {
            var locationDto = _mapper.Map<LocationDto>(location);
            var result = await _adminService.UpdateLocationAsync(locationId, locationDto);

            if (result)
                return Ok("Location updated successfully");
            else
                return NotFound("Location not found or failed to update");
        }

        [HttpPatch("locationPatch/{locationId}")]
        public async Task<IActionResult> PatchLocation(Guid locationId, [FromBody] LocationPatchRequest location)
        {
            // Map the request to DTO
            var locationDto = _mapper.Map<LocationDto>(location); // AutoMapper handles nulls
            var result = await _adminService.PatchLocationAsync(locationId, locationDto);

            if (result)
                return Ok("Location partially updated successfully");
            else
                return NotFound("Location not found or failed to update");
        }

        [HttpDelete("locationRemove/{locationId}")]
        public async Task<IActionResult> RemoveLocation(Guid locationId)
        {
            var result = await _adminService.RemoveLocationAsync(locationId);

            if (result)
                return Ok("Location deleted successfully");
            else
                return NotFound("Location not found or failed to delete");
        }
        [Authorize(Roles = "Admin")]
        [HttpPost("logout")]
       
        public async Task<IActionResult> Logout()
        {
            // Extract the AdminId from the JWT claims
            var adminIdClaim = User.Claims.FirstOrDefault(c => c.Type.Contains("sid"))?.Value;
            if (adminIdClaim == null)
                return Unauthorized("Invalid token — cannot find user information.");

            var adminId = Guid.Parse(adminIdClaim);

            // Call the service to mark the user as offline
            var result = await _loginRequestService.LogoutAsync(adminId);

            if (!result)
                return BadRequest("Logout failed or user not found.");

            return Ok("Logout successful.");
        }


    }
}
