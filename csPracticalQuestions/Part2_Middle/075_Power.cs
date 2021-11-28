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
           for (int i = 0; i <= 20; i++)
                Console.WriteLine("2 ^ {0,2} = {1, 7}", i, Power(2, i));
        }

        private static int Power(int v, int i)
        {
            int p = 1;
            for (int j = 1; j <= i; j++)
                p *= v;
            return p;
        }
    }
}


