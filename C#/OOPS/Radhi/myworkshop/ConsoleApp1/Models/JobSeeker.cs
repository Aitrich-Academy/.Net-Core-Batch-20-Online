using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobApplication.Enums;

namespace JobApplication.Models
{
    public class JobSeeker
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification { get; set; }
        public ExprienceLevels ExperienceLevel { get; set; }
        public string Password { get; set; }
    }
}
