using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospitalManagement.Dto;
using HospitalManagement.Service;

namespace HospitalManagement.Pages.Doctor
{
    public class createModel : PageModel
    {
        private readonly DoctorService _service;
        public createModel(DoctorService  service)
        {
            _service = service;
        }
        [BindProperty]
        public DoctorDto mydoctor { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddDoctorAsync (mydoctor);
            return RedirectToPage("index");
        }
    }
}
