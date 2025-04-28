using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortalApplication.Models;
using static System.Net.Mime.MediaTypeNames;

namespace JobPortalApplication.Managers
{
    public class Printer


    {

        public class Application
        {
            public int Id { get; set; }
            public int JobId { get; set; }
            public string ApplicantEmail { get; set; }
            public string ResumeText { get; set; }
        }
        public void Print(Job[] jobs)
        {
            foreach (var job in jobs)
            {
                Console.WriteLine($"[{job.Id}] {job.Title} at {job.Company} - {job.Location} - {job.Salary}");
            }
        }

        public void Print(Interview[] interviews)
        {
            foreach (var interview in interviews)
            {
                Console.WriteLine($"[{interview.Id}] {interview.Post} at {interview.Company} on {interview.Date} at {interview.Time}, {interview.Location}");
            }
        }

        public void Print(Application[] applications)
        {
            Console.WriteLine("Application printing not implemented.");
        }
    }
}
