using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobportal.Models;
using Jobportal.Repository;

namespace Jobportal.Manager
{
    public class Jobmanager
    {
        Jobrepository repository=new Jobrepository();

        public void Listjobs()
        {
            Console.WriteLine("\n-------Jobs-------\n");
            Console.WriteLine("{0,-5} | {1,-20} | {2,-20} | {3,-20} | {4,-20} | {5,-10} | {6,-10}  ", "ID", "Title", "Company", "Experience", "Location", "Salary", "JobType");
            List<Job> jobs = repository.GetAllJobs();
            foreach (Job job in jobs)
            {
                Console.WriteLine("{0,-5} | {1,-20} | {2,-20} | {3,-20} | {4,-20} | {5,-10} | {6,-10} ", job.Id, job.Title, job.Company, job.Experiencelevel, job.Location, job.Salary, job.Jobtype);
            }
        }
    }
}
