using HospitalManagement.Models;
using HospitalManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class IndexModel : PageModel
    {
     
            private readonly DoctorService _service;
            public List<Models.Doctor> doc { get; set; }

            public IndexModel(DoctorService service)
            {
                _service = service;
            }

            public async Task OnGetAsync()
            {
                doc = await _service.GetAllAsync();
            }
        }
    }
