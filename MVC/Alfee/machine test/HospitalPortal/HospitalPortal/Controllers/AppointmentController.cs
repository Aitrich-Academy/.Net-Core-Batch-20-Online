using HospitalPortal.Dtos;
using HospitalPortal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalPortal.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public IActionResult Index()
        {
            var appointments = _appointmentService.GetAllAppointments();
            return View(appointments);
        }

        public IActionResult Book()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Book(AppointmentDto appointmentDto)
        {
            if (ModelState.IsValid)
            {
                _appointmentService.BookAppointment(appointmentDto);
                return RedirectToAction("Index");
            }
            return View(appointmentDto);
        }

        public IActionResult MyAppointments(int patientId)
        {
            var appointments = _appointmentService.GetAppointmentsByPatient(patientId);
            return View(appointments);
        }
    }
}
