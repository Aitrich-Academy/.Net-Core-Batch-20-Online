using CompanyManagement.Dto;
using CompanyManagement.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyManagement.Pages.Members
{
    public class EditModel : PageModel
    {
        private readonly ICompanyMemberService _companyMemberService;

        public EditModel(ICompanyMemberService companyMemberService)
        {
            _companyMemberService = companyMemberService;
        }

        [BindProperty]
        public CompanyMemberDto MemberDto { get; set; }

        public string Message { get; set; }

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
                Message = "Member not found or access denied.";
                return RedirectToPage("Index");
            }

            MemberDto = member;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToPage("/Users/Login");
            }

            MemberDto.UserId = userId.Value;

            var success = await _companyMemberService.UpdateMemberAsync(MemberDto);
            if (!success)
            {
                Message = "Failed to update member.";
                return Page();
            }

            return RedirectToPage("Index");
        }
    }
}
