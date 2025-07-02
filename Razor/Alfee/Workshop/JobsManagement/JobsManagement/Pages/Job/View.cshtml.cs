using JobsManagement.Model;
using JobsManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobsManagement.Pages.Job
{
    public class ViewModel : PageModel
    {
        private readonly JobService _service;

        public ViewModel(JobService service)
        {
            _service = service;
        }

        public Jobs Job { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Job = await _service.GetJobByIdAsync(id);

            if (Job == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}