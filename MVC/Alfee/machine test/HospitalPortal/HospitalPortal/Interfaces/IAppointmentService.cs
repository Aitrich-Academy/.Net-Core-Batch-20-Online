using HospitalPortal.Dtos;

namespace HospitalPortal.Interfaces
{
    public interface IAppointmentService
    {
        void BookAppointment(AppointmentDto appointmentDto);
        IEnumerable<AppointmentDto> GetAppointmentsByPatient(int patientId);
        IEnumerable<AppointmentDto> GetAllAppointments();
    }
}
