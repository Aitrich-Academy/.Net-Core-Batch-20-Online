using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4.Models
{
    internal class Application
    {
        public int JobId { get; set; }

        public int UserId;
        public string Title { get; set; }
        public string Description { get; set; }

        public string Location { get; set; }
        public string Type { get; set; }
        public string Salaryrange { get; set; }

        public string Company { get; set; }

        public Application(int jobId, int userId, string title, string description, string location, string type, string salaryrange, string company)
        {
            JobId = jobId;
            UserId = userId;
            Title = title;
            Description = description;
            Location = location;
            Type = type;
            Salaryrange = salaryrange;
            Company = company;
        }
    }
}
