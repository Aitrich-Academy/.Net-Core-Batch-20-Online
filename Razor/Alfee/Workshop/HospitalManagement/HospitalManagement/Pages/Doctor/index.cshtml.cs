using HospitalManagement.Model;
using HospitalManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagement.Pages.Doctor
{
    public class indexModel : PageModel
    {
        private readonly DoctorServices _services;
        public List<Doctors> DoctorPosts { get; set; }

        public indexModel(DoctorServices services)
        {
            _services = services;
        }

        public async Task OnGetAsync()
        {
            DoctorPosts = await _services.GetAllDoctorsAsync();
        }
    }
}
