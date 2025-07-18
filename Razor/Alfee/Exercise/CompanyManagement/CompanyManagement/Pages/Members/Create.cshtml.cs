using CompanyManagement.Dto;
using CompanyManagement.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyManagement.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly ICompanyMemberService _memberService;
        [BindProperty]
        public CompanyMemberDto MemberDto { get; set; } 
        public string? Message { get; set; }

        public CreateModel(ICompanyMemberService memberService)
        {
            _memberService = memberService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToPage("/Users/Login");
            }

            var success = await _memberService.AddMemberAsync(MemberDto, userId.Value);

            if (success)
            {
                return RedirectToPage("/Members/Index");  // 🔁 Go to Index after adding
            }

            Message = "Error adding member.";
            return Page();  // Show the same page if adding failed
        }
    }
}
