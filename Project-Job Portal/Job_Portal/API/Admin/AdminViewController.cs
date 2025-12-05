//using AutoMapper;
//using Domain.Service.Admin;
//using Domain.Service.Admin.DTOs;
//using Domain.Service.Admin.Interfaces;
//using Job_Portal.API.Admin.Request_Objects;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Job_Portal.API.Admin
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AdminViewController : ControllerBase
//    {
//        private readonly IAdminServices _adminService;
//        private readonly IMapper _mapper;
//        public AdminViewController(IAdminServices adminService, IMapper mapper)
//        {
//            _adminService = adminService;
//            _mapper = mapper;
//        }
//        // ✅ Get total job count
//        [HttpGet("Jobcount")]
//        public async Task<IActionResult> GetJobCount()
//        {
//            var count = await _adminService.GetJobCountAsync();
//            return Ok(new { TotalJobs = count });
//        }


//        // ✅ Get job by name
//        [HttpGet("getbyname/{jobTitle}")]
//        public async Task<IActionResult> GetJobByName(string jobTitle)
//        {
//            var job = await _adminService.GetJobByNameAsync(jobTitle);

//            if (job == null)
//                return NotFound(new { Message = $"No job found with title '{jobTitle}'." });

//            return Ok(job);
//        }

//        [HttpGet("GetAllJobProviders")]
//        public async Task<IActionResult> GetAllJobProviders()
//        {
//            var providers = await _adminService.GetAllProviders();
//            var allproviders = _mapper.Map<List<JobProviderRequestDto>>(providers);
//            return Ok(providers);
//        }


//        [HttpGet("GetJobProviderById/{id}")]

//        public async Task<IActionResult> GetJobProviderById(Guid id)
//        {
//            var jobprovider = await _adminService.GetJobProviderByIdAsync(id);

//            if (jobprovider == null)
//                return NotFound("JobProvider not found");
//            var providerById = _mapper.Map<JobProviderRequestDto>(jobprovider);
//            return Ok(providerById);
//        }


//        // ✅ Get total jobProvider count
//        [HttpGet("JobProvidercount")]
//        public async Task<IActionResult> GetJobProviderCount()
//        {
//            var count = await _adminService.GetJobProviderCountAsync();
//            //return Ok(count);
//            return Ok(new { TotalJobProvider = count });
//        }


//        [HttpDelete("DeleteJobProvider/{id}")]

//        public async Task<IActionResult> DeleteJobProvider(Guid id)
//        {
//            var deleted = await _adminService.DeleteJobProviderAsync(id);

//            if (!deleted)
//                return NotFound("JobProvider not found.");

//            return Ok(new { Message = "JobProvider deleted successfully." });
//        }

//    }
//}
