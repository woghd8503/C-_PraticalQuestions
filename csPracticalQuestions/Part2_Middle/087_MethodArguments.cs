﻿using System;
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
        static void Main(String[] args)
        {
            int a = 3;
            Sqr(a);
            Console.WriteLine("Value: {0}", a); // 3이 출력됩니다.

            int b = 3;
            Sqr(ref b);
            Console.WriteLine("ref: {0}", b); // 9가 출력됩니다.

            string name;
            int id;
            GetName(out name, out id);
            Console.WriteLine("out: {0} {1}", name, id);
        }

        static void Sqr(int x)
        {
            x = x * x;
        }

        static void Sqr(ref int x)
        {
            x = x * x;
        }

        static void GetName(out string name, out int id)
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Id: ");
            id = int.Parse(Console.ReadLine());
        }
    }
}