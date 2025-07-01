using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RazorEmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        [Precision(18, 2)] 
        public decimal Salary { get; set; }

        [Required]
        public string Department { get; set; }
    }
}
