using CompanyManagement.Dto;
using CompanyManagement.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyManagement.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly ICompanyMemberService _companyMemberService;

        public IndexModel(ICompanyMemberService companyMemberService)
        {
            _companyMemberService = companyMemberService;
        }

        public List<CompanyMemberDto> Members { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToPage("/Users/Login");
            }

            Members = await _companyMemberService.GetMembersByUserIdAsync(userId.Value);
            return Page();
        }
    }

}
