using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMember.Models;

namespace CompanyMember
{
    internal class Lists
    {
        public void print(List<Company> companies)
        {
            Console.WriteLine("-----------Companies-----------\n");

            Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} |  {5,-15} |  {6,-15} |  {7,-15} |  {8,-15}  ", "Name", "Email", "website", "phone", "about", "vision", "mission", "location", "address");

            if (companies != null)
                foreach (Company company in companies)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");

                    Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} |  {5,-15} |  {6,-15} |  {7,-15} |   {8,-15} |  ", company.Name, company.Email, company.Website, company.Phone, company.About, company.Vision, company.Mission, company.Location, company.Address);
                }

            Console.WriteLine("\n");

        }
        public void Print(List<Job> jobs)
        {
            Console.WriteLine("Jobs available: \n");
            Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} |  {5,-15} |  {6,-15}   ", "JobId", "Title", "ExperienceLevel", "Company", "Location", "SalaryRange", "JobType");

            foreach (Job job in jobs)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4,-15} |  {5,-15} |  {6,-15}   ", job.Id, job.Title, job.ExperienceLevel, job.Company, job.Location, job.SalaryRange, job.JobType);
            }

            Console.WriteLine("\n");
        }
    }
}
