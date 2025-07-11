using CompanyManagement.Dto;
using CompanyManagement.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyManagement.Pages.Members
{
    public class DeleteModel : PageModel
    {
        private readonly ICompanyMemberService _companyMemberService;

        public DeleteModel(ICompanyMemberService companyMemberService)
        {
            _companyMemberService = companyMemberService;
        }

        [BindProperty]
        public CompanyMemberDto Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToPage("/Users/Login");

            var member = await _companyMemberService.GetMemberByIdAsync(id);
            if (member == null || member.UserId != userId)
                return RedirectToPage("Index");

            Member = member;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return RedirectToPage("/Users/Login");

            var deleted = await _companyMemberService.DeleteMemberAsync(Member.Id, userId.Value);
            if (!deleted)
            {
                // Optionally set an error message
                return Page();
            }

            return RedirectToPage("Index");
        }
    }
}
