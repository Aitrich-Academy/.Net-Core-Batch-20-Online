using HospitalPortal.Interfaces;
using HospitalPortal.Models;

namespace HospitalPortal.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext _context;

        public DoctorRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public Doctor? GetById(int id)
        {
            return _context.Doctors.Find(id);
        }

        public IEnumerable<Doctor> GetAll()
        {
            return _context.Doctors.ToList();
        }
    }
}
