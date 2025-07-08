using HospitalManagement.Dto;
using HospitalManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class createModel : PageModel
    {
        private readonly DoctorServices _services;

        [BindProperty]
        public DoctorDto DoctorPost { get; set; }

        public createModel(DoctorServices services)
        {
            _services = services;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _services.AddDoctorAsync(DoctorPost);
            return RedirectToPage("index");
        }
    }
}
