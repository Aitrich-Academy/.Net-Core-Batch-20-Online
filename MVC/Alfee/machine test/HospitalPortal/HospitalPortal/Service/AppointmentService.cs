using AutoMapper;
using HospitalPortal.Dtos;
using HospitalPortal.Interfaces;
using HospitalPortal.Models;

namespace HospitalPortal.Service
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepo;
        private readonly IMapper _mapper;

        public AppointmentService(IAppointmentRepository appointmentRepo, IMapper mapper)
        {
            _appointmentRepo = appointmentRepo;
            _mapper = mapper;
        }

        public void BookAppointment(AppointmentDto appointmentDto)
        {
            var appointment = _mapper.Map<Appointment>(appointmentDto);
            _appointmentRepo.BookAppointment(appointment);
        }

        public IEnumerable<AppointmentDto> GetAppointmentsByPatient(int patientId)
        {
            var appointments = _appointmentRepo.GetAppointmentsByPatient(patientId);
            return _mapper.Map<IEnumerable<AppointmentDto>>(appointments);
        }

        public IEnumerable<AppointmentDto> GetAllAppointments()
        {
            var appointments = _appointmentRepo.GetAllAppointments();
            return _mapper.Map<IEnumerable<AppointmentDto>>(appointments);
        }
    }
}
