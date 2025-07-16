using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPortal.Dto;
using JobPortal.Model;
using JobPortal.Service;
using Hangfire.Storage.Monitoring;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Http;
using Azure;
using Microsoft.AspNetCore.Routing;

namespace JobPortal.Pages.MyJob
{
    public class ListJobsModel : PageModel
    {
        private readonly JobService _service;
        private readonly ApplicationDbContext _context;
        
        public ListJobsModel (JobService service, ApplicationDbContext context)
        {
            _service = service;
            _context = context;
        }
        public List<Jobs> JobPosts { get; set; }
        public string Username { get; private set;}
        public int userId { get; private set; }
         

        
          
        public async Task OnGetAsync()
        {
            Username = HttpContext.Session.GetString("User");
          
            JobPosts = await _service.GetAllJobsAsync();

        }

      
        public async Task<IActionResult?> OnPostAsync(int jobId)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            _context.AppliedJobs.Add(new Applied
            {
                UserId = (int)userId,
                JobId = jobId,
                AppliedDate = DateTime.UtcNow
            });
            await _context.SaveChangesAsync();
            return RedirectToPage();
        }


    }
}
 //< button type = "submit" asp - route - id = "@job.Id" class= "btn btn-primary" > Apply </ button >
// < a asp - page = "/MyJob/view" asp - route - id = "@job.Id" class= "btn btn-warning btn-sm" > Apply </ a >