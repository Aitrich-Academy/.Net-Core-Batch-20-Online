using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalApplication.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Post { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }
    }

    public class Application
    {
        public int JobId { get; set; }
        public string CandidateEmail { get; set; }
    }
}

