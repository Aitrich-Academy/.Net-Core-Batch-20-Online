using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Models;

namespace Admin
{
     public class Lists
    {
        public void print(List<User> Admins)
        {
            Console.WriteLine("\n------Registrations------\n");
            Console.WriteLine("{0,-10}  |  {1,-20}  |  {2,-20}  |  {3,-20}  |  {4,-20}", "Id", "Firstname", "Lastname", "Email", "Phone");
            if (Admins != null)
            {
                foreach (User user in Admins)
                {
                    Console.WriteLine("{0,-10}  |  {1,-20}  |  {2,-20}  |  {3,-20}  |  {4,-20}", user.Id,user.Firstname,user.Lastname,user.Email,user.Phone);
                }
            }
        }


        public void print(List<Job> Jobs)
        {
            Console.WriteLine("\n------Jobs--------\n");
            Console.WriteLine("{0,-10} |  {1,-20}  |  {2,-20}  |  {3,-20}  |  {4,-20}  |  {5,-20}","ID", "Title", "Description", "Company", "Location", "Salary");
            if (Jobs != null)
            {
                foreach (Job job in Jobs)
                {
                    Console.WriteLine("{0,-10} |  {1,-20}  |  {2,-20}  |  {3,-20}  |  {4,-20}  |  {5,-20}", job.Id, job.Title, job.Description, job.Company, job.Location, job.Salary);

                }
            }
        }
    }
}
