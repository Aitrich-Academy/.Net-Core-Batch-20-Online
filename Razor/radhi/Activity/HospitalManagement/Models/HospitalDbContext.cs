using HospitalManagement.Repository;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    public class HospitalDbContext:DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options) { }
        public DbSet<Doctor> Doctors { get; set; }

        public static implicit operator HospitalDbContext(DoctorRepository v)
        {
            throw new NotImplementedException();
        }
    }
}
