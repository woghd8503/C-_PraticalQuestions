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
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);
        }

        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.WriteLine("*");
                Console.WriteLine();
            }
        }
    }
}


