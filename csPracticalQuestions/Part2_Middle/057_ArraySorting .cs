﻿using System;
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
            string[] name = { "Mouse", "Cow", "Tiger", "Rabbit", "Dragon", "Snake", "Horse" };
            PrintArray("Before Sort: ", name);

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);

            Array.Sort(name);
            PrintArray("After Sort: ", name);

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);

        }

        private static void PrintArray(string s, string[] name)
        {
            Console.Write(s);
            foreach (var n in name)
                Console.WriteLine("{0} ", n);
            Console.WriteLine();
        }
    }
}


