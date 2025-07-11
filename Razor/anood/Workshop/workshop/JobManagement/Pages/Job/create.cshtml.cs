using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobManagement.Dto;
using JobManagement.Service;

namespace JobManagement.Pages.Job
{
    public class createModel : PageModel
    {
        private readonly JobService _service;

        [BindProperty]
        public JobDto JobPost { get; set; }

        public createModel(JobService service)
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
