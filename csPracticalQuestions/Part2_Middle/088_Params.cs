using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Methods
    {
        public static void PrintIntParams(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintObjectParams(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(String[] args)
        {
            PrintIntParams(1, 2, 3, 4);
            PrintObjectParams(1, 1.234, 'a', "test");
            PrintObjectParams();

            int[] myIntArray = { 5, 6, 7, 8, 9 };
            PrintIntParams(myIntArray);

            object[] myObjArray = { 2, 2.2345, 'b', "test", "again" };
            PrintObjectParams(myObjArray);

            PrintObjectParams(myIntArray);
        }
    }
}