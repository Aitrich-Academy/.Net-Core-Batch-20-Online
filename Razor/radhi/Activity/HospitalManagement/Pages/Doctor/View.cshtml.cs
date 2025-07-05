using HospitalManagement.Dto;
using HospitalManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class ViewModel : PageModel
    {
        private readonly DoctorService _service;

        [BindProperty]
        public Models.Doctor doctor { get; set; }

        public ViewModel(DoctorService service)
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
    }
}