using JobsManagement.Dto;
using JobsManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobsManagement.Pages.Job
{
    public class CreateModel : PageModel
    {
        private readonly JobService _service;

        [BindProperty]
        public JobDto JobPost { get; set; }

        public CreateModel(JobService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddJobAsync(JobPost);
            return RedirectToPage("index");
        }
    }
}
