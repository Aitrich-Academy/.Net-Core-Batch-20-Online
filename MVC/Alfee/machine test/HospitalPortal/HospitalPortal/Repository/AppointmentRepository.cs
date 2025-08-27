using HospitalPortal.Interfaces;
using HospitalPortal.Models;

namespace HospitalPortal.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppDbContext _context;

        public AppointmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public void BookAppointment(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public IEnumerable<Appointment> GetAppointmentsByPatient(int patientId)
        {
            return _context.Appointments
                .Where(a => a.PatientId == patientId)
                .ToList();
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _context.Appointments.ToList();
        }
    }
}
