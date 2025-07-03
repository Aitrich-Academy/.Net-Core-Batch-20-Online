using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospitalManagement.Dto;
using HospitalManagement.Model;
using HospitalManagement.Service;

namespace HospitalManagement.Pages.Doctor
{
    public class adminModel : PageModel
    {
        private readonly DoctorService _service;
        public List<Doctors> mydoctor { get; set; }
         
        public adminModel(DoctorService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            
            mydoctor = await _service.GetAllDoctorsAsync();

        }
    }
}
