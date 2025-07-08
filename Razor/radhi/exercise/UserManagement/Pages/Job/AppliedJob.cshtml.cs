using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserManagement.Service;
using UserManagement.Models;
using UserManagement.Interface;

namespace UserManagement.Pages.Job
{
    public class AppliedListModel : PageModel
    {
        private readonly IAppliedService _service;

        public AppliedListModel(IAppliedService service)
        {
            _service = service;
        }

        [BindProperty(SupportsGet = true)]
        public int UserId { get; set; }

        public List<Models.Job> AppliedJobs { get; set; }

        public async Task OnGetAsync()
        {
            AppliedJobs = await _service.GetAppliedJobsByUserIdAsync(UserId);
        }
    }
}

