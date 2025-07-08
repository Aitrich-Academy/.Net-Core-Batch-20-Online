using CompanyManagement.Dto;
using CompanyManagement.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyManagement.Pages.Members
{
    public class ViewModel : PageModel
    {
        private readonly ICompanyMemberService _companyMemberService;

        public ViewModel(ICompanyMemberService companyMemberService)
        {
            _companyMemberService = companyMemberService;
        }

        public CompanyMemberDto Members { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToPage("/Users/Login");
            }

            var member = await _companyMemberService.GetMemberByIdAsync(id);
            if (member == null || member.UserId != userId)
            {
                return RedirectToPage("Index");
            }

            Members = member;
            return Page();
        }
    }
}
