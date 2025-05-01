using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.Enums;

namespace project.Models
{
    public class User
    {



        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public Roles Role { get; set; }
        public Job[] AppliedJobs = new Job[10];
        public int AppliedJobCount = 0;
        public Job[] SavedJobs = new Job[10];
        public int SavedJobCount = 0;

    }

}


