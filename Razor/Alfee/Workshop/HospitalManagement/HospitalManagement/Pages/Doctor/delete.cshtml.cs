using HospitalManagement.Model;
using HospitalManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class deleteModel : PageModel
    {
        private readonly DoctorServices _services;

        public deleteModel(DoctorServices services)
        {
            _services = services;
        }

        [BindProperty]
        public Doctors DoctorPost { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            DoctorPost = await _services.GetDoctorsByIdAsync(id);

            if (DoctorPost == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _services.DeleteDoctorAsync(id);
            return RedirectToPage("index");
        }
    }
}
