using HospitalManagement.Model;
using HospitalManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class viewModel : PageModel
    {
        private readonly DoctorServices _services;

        public viewModel(DoctorServices services)
        {
            _services = services;
        }

        public Doctors Doctor { get; set; }
        public string Message { get; set; }

        public async Task<IActionResult> OnGetAsync(int id, bool bookNow = false)
        {
            Doctor = await _services.GetDoctorsByIdAsync(id);

            if (Doctor == null)
            {
                return NotFound();
            }

            if (bookNow)
            {
                Message = " Appointment Booked Successfully!";
            }

            return Page();
        }
    }
}
