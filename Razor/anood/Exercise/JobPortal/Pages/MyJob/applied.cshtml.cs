using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPortal.Dto;
using JobPortal.Service;
using JobPortal.Model;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Azure;
using Hangfire.Common;
using Microsoft.AspNetCore.Identity;

namespace JobPortal.Pages.MyJob
{
    public class appliedModel : PageModel
    {
        private readonly AppliedService _service;
        private readonly ApplicationDbContext _context;

        //public List<AppliedJobs> AppliedJobs { get; set; }

        public class AppliedJobDto
        {
            public int JobId { get; set; }
            public string Title { get; set; }
            public string Company { get; set; }
            public string Location { get; set; }
            public DateTime AppliedDate { get; set; }
        }

        public List<AppliedJobDto> AppliedJobs { get; set; }

        public appliedModel(AppliedService service, ApplicationDbContext context)
        {
            _service = service;
            _context = context;
        }

        public string Username { get; private set; }

        [BindProperty]
        public User myuser { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            AppliedJobs = await (from aj in _context.AppliedJobs
                                 join j in _context.Jobs on aj.JobId equals j.Id
                                 where aj.UserId == userId
                                 orderby aj.AppliedDate descending
                                 select new AppliedJobDto
                                 {
                                     JobId = j.Id,
                                     Title = j.JobTitle,
                                     Company = j.Company,
                                     Location = j.Location,
                                     AppliedDate = aj.AppliedDate
                                 })
                           .AsNoTracking()
                           .ToListAsync();

            return Page();
        }



    }
}
