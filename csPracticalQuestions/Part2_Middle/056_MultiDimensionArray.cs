using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2차원 배열: arrA[2,3]");
            int[,] arrA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i = 0; i < 2; i++)
            {
                for ( int j = 0; j < 3; j++)
                    Console.WriteLine(");
            }
        }

        private static void PrintArray(int[] a)
        {
            foreach(var i in a)
                Console.Write("{0,5}", i);
            Console.WriteLine();
        }
    }
}


