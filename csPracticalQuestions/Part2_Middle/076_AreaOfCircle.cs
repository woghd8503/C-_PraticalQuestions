using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Methods
    {
        static void Main(String[] args)
        {
           for (double r = 1; r <= 10; r++)
                Console.WriteLine("Area of circle with radius {0,2} = {1,7:F2}", r, AreaOfCircle(r));
        }

        private static double AreaOfCircle(double r)
        {
            return Math.PI * r * r;
        }
    }
}


