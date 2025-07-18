using JOBMANAGEMENT.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JOBMANAGEMENT.Pages.Jobs
{
    public class DeleteModel : PageModel
    {
        private readonly JobService _service;

        public DeleteModel(JobService service)
        {
            _service = service;
        }

        [BindProperty]
        public Models.Job JobPost { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            JobPost = await _service.GetJobByIdAsync(id);

            if (JobPost == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _service.DeleteJobAsync(id);
            return RedirectToPage("Index");
        }
    }
       
}
