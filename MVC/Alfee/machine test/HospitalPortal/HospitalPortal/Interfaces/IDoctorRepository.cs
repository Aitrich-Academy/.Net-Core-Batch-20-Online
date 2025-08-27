using HospitalPortal.Models;

namespace HospitalPortal.Interfaces
{
    public interface IDoctorRepository
    {
        void AddDoctor(Doctor doctor);
        Doctor? GetById(int id);
        IEnumerable<Doctor> GetAll();
    }
}
