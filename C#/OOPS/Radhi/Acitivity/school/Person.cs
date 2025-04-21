using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace school
{
    public abstract class Person
    {
        public string Name;
        public int Age;
        public abstract void GetRole();
       
        public void ShowDetails()
        {
            Console.WriteLine($"Name:{Name}  \nAge:{Age}");

        }

        

    }
}
