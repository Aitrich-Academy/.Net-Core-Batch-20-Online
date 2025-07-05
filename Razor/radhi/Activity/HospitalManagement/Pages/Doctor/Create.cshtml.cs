using HospitalManagement.Dto;
using HospitalManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class CreateModel : PageModel
    {
        private readonly DoctorService _service;

        [BindProperty]
        public Models.Doctor Doctors { get; set; }

        public CreateModel(DoctorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddDoctorAsync(Doctors);
            return RedirectToPage("Index");
        }
    }
}
