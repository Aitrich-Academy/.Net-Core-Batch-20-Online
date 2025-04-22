using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_constructer
{
    internal class Friuts
    {
        public string Name;
        public string color;

        public Friuts(string fname, string fcolor)
        {
            Name = fname;
            color = fcolor;
        }

        public void display()
        {
            Console.WriteLine($"fruitname:{Name},fruitcolor:{color}");
        }

    }
}
