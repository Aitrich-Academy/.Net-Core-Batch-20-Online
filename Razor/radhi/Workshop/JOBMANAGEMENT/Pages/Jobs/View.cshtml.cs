using JOBMANAGEMENT.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JOBMANAGEMENT.Pages.Jobs
{
    public class ViewModel : PageModel
    {
        private readonly JobService _service;

        [BindProperty]
        public Models.Job JobPost { get; set; }

        public ViewModel(JobService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var jobDto = await _service.GetJobByIdAsync(id);
            if (jobDto == null)
            {
                return NotFound();
            }

            JobPost = jobDto;
            return Page();
        }

    }
}
