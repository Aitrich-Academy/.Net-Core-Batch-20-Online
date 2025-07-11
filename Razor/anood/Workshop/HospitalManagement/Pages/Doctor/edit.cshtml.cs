using HospitalManagement.Dto;
using HospitalManagement.Model;
using HospitalManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace HospitalManagement.Pages.Doctor
{
    public class editModel : PageModel
    {
        private readonly DoctorService _service;

        public editModel(DoctorService service)
        {
            _service = service;
        }

        [BindProperty]
        public Doctors mydoct { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var doctDto = await _service.GetDoctorByIdAsync(id);
            if (doctDto == null)
            {
                return NotFound();
            }

            mydoct = doctDto;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            await _service.UpdateDoctorsAsync( mydoct.Id ,mydoct);
            return RedirectToPage("admin");
        }
    }
}
