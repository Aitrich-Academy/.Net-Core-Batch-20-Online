using HospitalManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospitalManagement.Models;


namespace HospitalManagement.Pages.Doctor
{
    public class BookingModel : PageModel
    {
        private readonly DoctorService _service;
        public List<Models.Doctor> doc { get; set; }

        public BookingModel(DoctorService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            doc = await _service.GetAllAsync();
        }
    }
}
