using HospitalPortal.Models;

namespace HospitalPortal.Interfaces
{
    public interface IAppointmentRepository
    {
        void BookAppointment(Appointment appointment);
        IEnumerable<Appointment> GetAppointmentsByPatient(int patientId);
        IEnumerable<Appointment> GetAllAppointments();
    }
}
