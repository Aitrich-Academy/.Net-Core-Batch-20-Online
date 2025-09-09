using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class JobDto
    {
         public int Id { get; set; }
         public string Title { get; set; }
         public string Description { get; set; }
         public string Company {  get; set; }
         public string Location {  get; set; }
         public double Salary { get; set; }

    }
}
