using Domain.Service.JobProvider;
using Domain.Service.JobProvider.Interfaces;
using Job_Portal.API.JobProvider.RequestObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Job_Portal.API.JobProvider
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobProviderController : ControllerBase
    {
        private readonly IJobProviderService _service;

        public JobProviderController(IJobProviderService service)
        {
            _service = service;
        }

        // ================== Authentication ==================

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var (id, message) = await _service.RegisterAsync(request.Name, request.Email, request.Password);
            return Ok(new { JobProviderId = id, Message = message });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var (token, id, message) = await _service.LoginAsync(request.Email, request.Password);
            return Ok(new { Token = token, JobProviderId = id, Message = message });
        }

        // ================== Email Verification / OTP ==================
        [HttpPost("{jobProviderId}/send-otp")]
        public async Task<IActionResult> SendOtp(Guid jobProviderId)
        {
            var message = await _service.SendOtpAsync(jobProviderId);
            return Ok(new { Message = message });
        }

        [HttpPost("{jobProviderId}/verify-otp")]
        public async Task<IActionResult> VerifyOtp(Guid jobProviderId, [FromBody] VerifyOtpRequest request)
        {
            var message = await _service.VerifyOtpAsync(jobProviderId, request.OTP);
            return Ok(new { Message = message });
        }

        public class VerifyOtpRequest
        {
            public string OTP { get; set; } = null!;
        }

        // ================== Profile Picture ==================
        [HttpPost("{jobProviderId}/profile-picture")]
        public async Task<IActionResult> AddProfilePicture(Guid jobProviderId, [FromForm] ProfilePictureRequest request)
        {
            var message = await _service.AddProfilePictureAsync(jobProviderId, request.File);
            return Ok(new { Message = message });
        }

        [HttpPut("{jobProviderId}/profile-picture")]
        public async Task<IActionResult> UpdateProfilePicture(Guid jobProviderId, [FromForm] ProfilePictureRequest request)
        {
            var message = await _service.UpdateProfilePictureAsync(jobProviderId, request.File);
            return Ok(new { Message = message });
        }

        [HttpDelete("{jobProviderId}/profile-picture")]
        public async Task<IActionResult> DeleteProfilePicture(Guid jobProviderId)
        {
            var message = await _service.DeleteProfilePictureAsync(jobProviderId);
            return Ok(new { Message = message });
        }

        [HttpGet("{jobProviderId}/profile-picture")]
        public async Task<IActionResult> GetProfilePicture(Guid jobProviderId)
        {
            var url = await _service.GetProfilePictureAsync(jobProviderId);
            return Ok(new { ProfilePictureUrl = url });
        }

        // ================== Company ==================
        [HttpPost("{jobProviderId}/company")]
        public async Task<IActionResult> AddCompany(Guid jobProviderId, [FromBody] AddCompanyRequest request)
        {
            var (companyId, message) = await _service.AddCompanyAsync(jobProviderId, request.CompanyName, request.Location, request.Industry, request.WebsiteUrl);
            return Ok(new { CompanyId = companyId, Message = message });
        }

        [HttpGet("company/{companyId}")]
        public async Task<IActionResult> GetCompanyById(Guid companyId)
        {
            var company = await _service.GetCompanyByIdAsync(companyId);
            return Ok(company);
        }
        // ✅ GET ALL COMPANIES
        [HttpGet("companies")]
        public async Task<IActionResult> GetAllCompanies()
        {
            var companies = await _service.GetAllCompaniesAsync();
            return Ok(companies);
        }

        [HttpPut("company/{companyId}")]
        public async Task<IActionResult> UpdateCompany(Guid companyId, [FromBody] UpdateCompanyRequest request)
        {
            var message = await _service.UpdateCompanyByIdAsync(companyId, request.CompanyName, request.Location, request.Industry, request.WebsiteUrl);
            return Ok(new { Message = message });
        }

        [HttpPatch("company/{companyId}")]
        public async Task<IActionResult> PatchCompany(Guid companyId, [FromBody] PatchCompanyRequest request)
        {
            var message = await _service.PatchCompanyByIdAsync(companyId, request.Industry);
            return Ok(new { Message = message });
        }

        [HttpDelete("company/{companyId}")]
        public async Task<IActionResult> DeleteCompany(Guid companyId)
        {
            var message = await _service.DeleteCompanyByIdAsync(companyId);
            return Ok(new { Message = message });
        }

        // ================== Company Member ==================
        [HttpPost("company/{companyId}/member")]
        public async Task<IActionResult> AddCompanyMember(Guid companyId, [FromBody] AddCompanyMemberRequest request)
        {
            var (memberId, message) = await _service.AddCompanyMemberAsync(companyId, request.MemberName, request.Designation, request.Email, request.Phone);
            return Ok(new { MemberId = memberId, Message = message });
        }

        [HttpGet("company/member/{memberId}")]
        public async Task<IActionResult> GetCompanyMemberById(Guid memberId)
        {
            var member = await _service.GetCompanyMemberByIdAsync(memberId);
            return Ok(member);
        }

        // ✅ GET ALL COMPANY MEMBERS
        [HttpGet("company-members")]
        public async Task<IActionResult> GetAllCompanyMembers()
        {
            var members = await _service.GetAllCompanyMembersAsync();
            return Ok(members);
        }
    


        [HttpPut("company/member/{memberId}")]
        public async Task<IActionResult> UpdateCompanyMember(Guid memberId, [FromBody] UpdateCompanyMemberRequest request)
        {
            var message = await _service.UpdateCompanyMemberAsync(memberId, request.MemberName, request.Designation, request.Email, request.Phone);
            return Ok(new { Message = message });
        }

        [HttpPatch("company/member/{memberId}")]
        public async Task<IActionResult> PatchCompanyMember(Guid memberId, [FromBody] PatchCompanyMemberRequest request)
        {
            var message = await _service.PatchCompanyMemberAsync(memberId, request.Designation);
            return Ok(new { Message = message });
        }

        [HttpDelete("company/member/{memberId}")]
        public async Task<IActionResult> DeleteCompanyMember(Guid memberId)
        {
            var message = await _service.DeleteCompanyMemberAsync(memberId);
            return Ok(new { Message = message });
      }


        [HttpPost("logout/{jobProviderId}")]
        public async Task<IActionResult> Logout(Guid jobProviderId)
        {
            var result = await _service.LogoutAsync(jobProviderId);
            return Ok(new { Message = result });
        }





    }





}