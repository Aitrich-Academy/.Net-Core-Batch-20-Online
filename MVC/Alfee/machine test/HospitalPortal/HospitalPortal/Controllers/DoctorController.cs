using HospitalPortal.Dtos;
using HospitalPortal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalPortal.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        public IActionResult Index()
        {
            var doctors = _doctorService.GetAll();
            return View(doctors);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DoctorDto doctorDto)
        {
            if (ModelState.IsValid)
            {
                _doctorService.AddDoctor(doctorDto);
                return RedirectToAction("Index");
            }
            return View(doctorDto);
        }
    }
}
