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
            int i = 123;
            object o = i; // i의 값을 박싱하여 0로 복사합니다.
            i = i + 10; // i의 값을 바꿉니다. o는 변하지 않습니다.
            int j = (int)o; // o의 값을 언박싱하여 j로 복사합니다.

            // i의 값이 변해도 o에 저장된 값은 영향을 받지 않습니다.
            Console.WriteLine("The value-type value i = {0}", i);
            Console.WriteLine("The object-type value o = {0}", o);
            Console.WriteLine("The value-type value j = {0}", j);

            object p = o;
            o = 100;
            Console.WriteLine("The value-type value o = {0}", o);
            Console.WriteLine("The value-type value p = {0}", p);
        }
    }
}


