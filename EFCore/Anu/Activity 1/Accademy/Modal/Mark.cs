using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Modal
{
    public class Mark
    {
       
        public int Mark_Id { get; set; }
        public string Subject { get; set; }
        public int Subject_Mark { get; set; }
    }
}
