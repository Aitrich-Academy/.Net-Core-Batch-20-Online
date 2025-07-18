using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospitalManagement.Dto;
using HospitalManagement.Service;
using HospitalManagement.Model;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Pages.Doctor
{
    public class viewModel : PageModel
    {

        private readonly DoctorService _service;
        public viewModel(DoctorService service)
        {
            _service = service;
        }

        [BindProperty]
        public Doctors  mydoc { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var doctDto = await _service.GetDoctorByIdAsync(id);
            if (doctDto == null)
            {
                return NotFound();
            }

            mydoc = doctDto;
            return Page();
        }

    }
}
