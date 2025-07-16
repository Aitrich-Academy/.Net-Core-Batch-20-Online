using JobPortal.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Interface
{
    public interface  IAppliedRepository
    {

        //public Task ApplyToJobAsync(int userId, int jobId);
       // public Task OnPostAsync(int jobId);
    }
}


//public async Task<IActionResult> OnPostAsync(int jobId)
//{
//    var userId = int.Parse(User.FindFirst("UserId").Value);
//    _context.JobApplications.Add(new JobApplication
//    {
//        JobId = jobId,
//        AppUserId = userId,
//        AppliedOn = DateTime.UtcNow
//    });
//    await _context.SaveChangesAsync();
//    return RedirectToPage();
//}