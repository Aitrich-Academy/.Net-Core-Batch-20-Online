using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPortal.Dto;
using JobPortal.Service;
using JobPortal.Model;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Azure;
using Hangfire.Common;

namespace JobPortal.Pages.MyJob
{
    public class viewModel : PageModel
    {
        private readonly JobService _service;
        private readonly ApplicationDbContext _context;
        public viewModel(JobService service, ApplicationDbContext context)
        {
            _service = service;
            _context = context;
        }

        [BindProperty]
        public Jobs JobPost { get; set; }
        public bool HasApplied { get; set; }
        public string Username { get; private set; }
        public int userId { get; private set; }

        [BindProperty]
        public int JobPostId { get; set; }
         
        public async Task<IActionResult> OnGetAsync(int id)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            var jobDto = await _service.GetJobByIdAsync(id);
            HasApplied = await _context.AppliedJobs
           .AnyAsync(ja => ja.JobId == id && ja.UserId == userId);
            if (jobDto == null)
            {
                return NotFound();
            }

            JobPost = jobDto;
            return Page();
        }




        public async Task<IActionResult?> OnPostAsync(int Id)
        {


            Username = HttpContext.Session.GetString("User");
            int? userId = HttpContext.Session.GetInt32("UserId");

            var alreadyApplied = await _context.AppliedJobs
            .AnyAsync(ja => ja.JobId == JobPost.Id && ja.UserId == userId);

            if (!alreadyApplied)
            {
                _context.AppliedJobs.Add(new Applied
                {
                    UserId = (int)userId,
                    JobId = JobPost.Id,
                    AppliedDate = DateTime.UtcNow
                });
                await _context.SaveChangesAsync();
              
            }
            return RedirectToPage("/MyJob/ListJobs");
        }


    }
}


 