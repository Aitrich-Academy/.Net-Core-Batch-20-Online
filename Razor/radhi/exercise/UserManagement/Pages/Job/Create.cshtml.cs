using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserManagement.Dto;
using UserManagement.Interface; // Make sure this is added!

namespace UserManagement.Pages.Job
{
    public class CreateModel : PageModel
    {
        private readonly IJobService _service;

        [BindProperty]
        public JobDto JobPost { get; set; }

        public CreateModel(IJobService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddJobAsync(JobPost);
            return RedirectToPage("Index");
        }
    }
}
