using AutoMapper;
using Domain.Service.Admin;
using Domain.Service.Admin.DTOs;
using Domain.Service.Admin.Interfaces;
using Domain.Service.JobSeeker.DTOs;
using Domain.Service.Login.DTOs;
using Domain.Service.Login.Interfaces;
using Job_Portal.API.Admin.Request_Objects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatchJobCategoryDto = Job_Portal.API.Admin.Request_Objects.PatchJobCategoryDto;

namespace Job_Portal.API.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "ADMIN")]
    public class AdminController : ControllerBase
    {


        private readonly ILoginRequestService _loginRequestService;
        private readonly IMapper _mapper;

        private readonly IAdminServices _adminService;
        public AdminController(IMapper mapper, ILoginRequestService loginRequestService, IAdminServices adminService)
        {
            _mapper = mapper;
            _loginRequestService = loginRequestService;
            _adminService = adminService;

        }
        [AllowAnonymous]
        [HttpPost]


        [Route("Admin/login")]
        public async Task<IActionResult> AdminLogin([FromBody] AdminLoginRequests loginDto)
        {
            var mapdto = _mapper.Map<AdminLoginDTO>(loginDto);
            var result = await _loginRequestService.AdminLoginAsync(loginDto.Email, loginDto.Password);

            if (result == null)
                return Unauthorized("Invalid email or password");

            return Ok(result);
        }


        [HttpPost("AddIndustry")]

        public async Task<IActionResult> AddIndustry([FromBody] IndustryObjectDto request)
        {
            // Map API DTO → Domain DTO
            var domainRequest = _mapper.Map<IndustryDto>(request);

            var domainResult = await _adminService.AddIndustryAsync(domainRequest);

            // Map Domain DTO → API DTO
            var apiResponse = _mapper.Map<IndustryObjectDto>(domainResult);
            return Ok(apiResponse);
        }


        [HttpGet]
        [Route("GetAllIndustries")]


        public async Task<IActionResult> GetAllIndustries()
        {
            var domainIndustries = await _adminService.GetAllIndustriesAsync();

            // Map Domain DTO → API DTO
            var apiResponse = _mapper.Map<List<IndustryObjectDto>>(domainIndustries);

            return Ok(apiResponse);
        }


        [HttpGet("GetIndustryById/{id}")]

        public async Task<IActionResult> GetIndustryById(Guid id)
        {
            var industry = await _adminService.GetIndustryByIdAsync(id);

            if (industry == null)
                return NotFound("Industry not found");

            return Ok(industry);
        }

        [HttpGet("GetIndustryCount")]

        public async Task<IActionResult> GetIndustryCount()
        {
            var count = await _adminService.GetIndustryCountAsync();
            return Ok(count);
        }


        [HttpPut("EditIndustry/{id}")]

        public async Task<IActionResult> EditIndustry(Guid id, [FromBody] IndustryObjectDto request)
        {
            var dto = _mapper.Map<IndustryDto>(request);
            var updated = await _adminService.UpdateIndustryAsync(id, dto);

            if (updated == null)
                return NotFound("Industry not found.");

            return Ok(updated);
        }


        [HttpPatch("PatchIndustry/{id}")]

        public async Task<IActionResult> PatchIndustry(Guid id, [FromBody] PatchIndustryDto request)
        {
            if (request == null)
                return BadRequest("Invalid request data.");



            var updatedData = _mapper.Map<IndustryDto>(request);

            var updated = await _adminService.PatchIndustryAsync(id, updatedData);

            //if (updated == null)
            //    return NotFound("Industry not found.");

            if (updated == false)
    return NotFound("Industry not found.");

//var response = _mapper.Map<PatchIndustryDto>(updated);
//return Ok(response);

return Ok("Industry Updated successfully");
        }





        [HttpDelete("DeleteIndustry/{id}")]

public async Task<IActionResult> DeleteIndustry(Guid id)
{
    var deleted = await _adminService.DeleteIndustryAsync(id);

    if (!deleted)
        return NotFound("Industry not found.");

    return Ok(new { Message = "Industry deleted successfully." });
}


//Permission

[HttpPatch("ApproveJob/{id}")]
public async Task<IActionResult> ApproveJob(Guid id)
{
    var result = await _adminService.ApproveJobAsync(id);
    if (!result) return NotFound();
    return Ok("Job approved successfully");
}


[HttpPatch("RejectJob/{id}")]
public async Task<IActionResult> RejectJob(Guid id)
{
    var result = await _adminService.RejectJobAsync(id);
    if (!result) return NotFound();
    return Ok("Job rejected successfully");
}



[HttpPost("AddJobCategory")]
public async Task<IActionResult> Create([FromBody] CreateJobCategoryDto dto)
{
    var mappeddto = _mapper.Map<JobCategoryDto>(dto);
    var AddedCategory = await _adminService.CreateJobCategoryAsync(mappeddto);
    var Responsedto = _mapper.Map<CreateJobCategoryDto>(AddedCategory);
    return Ok(Responsedto);
}

[HttpGet("GetAllJobCategory")]
public async Task<IActionResult> GetAll()
{
    var result = await _adminService.GetAllJobCategoryAsync();
    return Ok(result);
}


[HttpGet("GetJobCategoryById/{id}")]
public async Task<IActionResult> GetJobCategoryById(Guid id)
{
    var result = await _adminService.GetJobCategoryByIdAsync(id);
    if (result == null) return NotFound();
    return Ok(result);
}


[HttpPut("UpdateJobCategory/{id}")]
public async Task<IActionResult> Update(Guid id, CreateJobCategoryDto dto)
{
    var mappeddto = _mapper.Map<JobCategoryDto>(dto);
    var updated = await _adminService.UpdateJobCategoryAsync(id, mappeddto);
    if (!updated) return NotFound();
    return Ok("Job category updated successfully.");
}


[HttpPatch("PatchJobCategory/{id}")]
public async Task<IActionResult> PatchJobCategory(Guid id, [FromBody] PatchJobCategoryDto dto)
{
    var mapper = _mapper.Map<PatchJobCategoryDTO>(dto);
    var result = await _adminService.PatchJobCategoryAsync(id, mapper);
    if (!result)
        return NotFound("Job category not found.");

    return Ok("Job category updated successfully.");
}


[HttpDelete("DeleteJobCategory/{id}")]

public async Task<IActionResult> DeleteJobCategory(Guid id)
{
    var deleted = await _adminService.DeleteJobCategoryAsync(id);

    if (!deleted)
        return NotFound("JobCategory not found.");

    return Ok(new { Message = "JobCategory deleted successfully." });
}







    }




}
