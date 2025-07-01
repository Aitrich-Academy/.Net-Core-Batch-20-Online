using JOBMANAGEMENT.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JOBMANAGEMENT.Pages.Jobs
{
    public class IndexModel : PageModel
    {

        private readonly JobService _service;
        public List<Models.Job> JobPosts { get; set; }

        public IndexModel(JobService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            JobPosts = await _service.GetAllJobsAsync();
        }
    }
     
}
