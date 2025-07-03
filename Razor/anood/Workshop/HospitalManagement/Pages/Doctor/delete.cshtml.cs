using HospitalManagement.Dto;
using HospitalManagement.Model;
using HospitalManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class deleteModel : PageModel
    {

        private readonly DoctorService _service;

        public deleteModel(DoctorService service)
        {
            _service = service;
        }

        [BindProperty]
        public Doctors mydoct { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            mydoct = await _service.GetDoctorByIdAsync(id);

            if (mydoct == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _service.DeleteDoctorAsync(id);
            return RedirectToPage("admin");
        }
    }
}
