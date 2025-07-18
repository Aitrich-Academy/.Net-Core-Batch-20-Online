using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobManagement.Dto;
using JobManagement.Model;
using JobManagement.Service;

namespace JobManagement.Pages.Job
{
    public class indexModel : PageModel
    {
        private readonly JobService _service;
        public List<Jobs> JobPosts { get; set; }
        public indexModel(JobService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            JobPosts = await _service.GetAllJobsAsync();
        }
    }
}
