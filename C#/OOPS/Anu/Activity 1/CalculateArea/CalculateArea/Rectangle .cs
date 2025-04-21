using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Rectangle
    {
        public double Length;
        public double Width;

        public double CalculateArea()
        {
            return Length * Width;
        }
    }
}
