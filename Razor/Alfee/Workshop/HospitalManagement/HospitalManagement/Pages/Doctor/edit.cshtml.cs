using HospitalManagement.Interface;
using HospitalManagement.Model;
using HospitalManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class editModel : PageModel
    {
        private readonly DoctorServices _services;

        [BindProperty]
        public Doctors DoctorPost { get; set; }

        public editModel(DoctorServices services)
        {
            _services = services;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var jobDto = await _services.GetDoctorsByIdAsync(id);
            if (jobDto == null)
            {
                return NotFound();
            }

            DoctorPost = jobDto;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _services.UpdateDoctorAsync(DoctorPost.Id, DoctorPost);
            return RedirectToPage("index");
        }
    }
}

//public async Task<IActionResult> OnPostAsync()
//{

//    await _service.UpdateJobAsync(JobPost.Id, JobPost);
//    return RedirectToPage("index");
//}