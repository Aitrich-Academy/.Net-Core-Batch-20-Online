using HospitalManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class DeleteModel : PageModel
    {
        private readonly DoctorService _service;

        public DeleteModel(DoctorService service)
        {
            _service = service;
        }

        [BindProperty]
        public Models.Doctor Doctor { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Doctor = await _service.GetDoctorByIdAsync(id);

            if (Doctor == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _service.DeleteDoctorAsync(id);
            return RedirectToPage("Index");
        }
    }
}

