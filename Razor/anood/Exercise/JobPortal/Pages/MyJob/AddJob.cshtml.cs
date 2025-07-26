using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPortal.Dto;
using JobPortal.Service;
using Hangfire.MemoryStorage.Dto;

namespace JobPortal.Pages.MyJob
{
    public class AddJobModel : PageModel
    {
        private readonly JobService _service;

        [BindProperty]
        public JobsDto JobPost { get; set; }

        public AddJobModel(JobService service)
        {
            _service = service;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddJobsAsync(JobPost);
            return RedirectToPage("/Index");
        }
    }
}
