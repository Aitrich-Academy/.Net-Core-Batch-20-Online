using HospitalManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class EditModel : PageModel
    {
        private readonly DoctorService _service;

        [BindProperty]
        public Models.Doctor doctor { get; set; }

        public EditModel(DoctorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var doctorDto = await _service.GetDoctorByIdAsync(id);
            if (doctorDto == null)
            {
                return NotFound();
            }

           doctor = doctorDto;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _service.UpdateDoctorAsync(doctor.Id, doctor);
            return RedirectToPage("Index");
        }
    }
}

