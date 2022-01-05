using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// 컬렉션이란 같은 형의 데이터를 모아서 처리하느 자료구조입니다. 배열로 컬렉션의 하나입니다. 컬렉션에는 "제네릭 컬렉션"과 "제네릭이 아닌 컬렉션"의 두 가지 유형이
// 있습니다. .NET Framework 2.0에서 추가된 제너릭 컬렉션은 컴파일 타임에 형식이 안전한(type-safe) 컬렉션을 제공합니다. 이로 인해 제네릭 컬렉션은 일반적으로 성능이
// 더 뛰어납니다.



namespace ConsoleApp1
{
   class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Random r = new Random();

            PrintValues(a);

            for (int i = 0; i < 10; i++)
                a.Add(r.Next(100));

            PrintValues(a);
            a.Sort();
            PrintValues(a);

            a.RemoveAt(3);
            PrintValues(a);
        }

        private static void PrintValues(ArrayList a)
        {
            Console.WriteLine("Print in ArrayList");
            Console.WriteLine("  Count = {0}", a.Count);
            Console.WriteLine("  Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write("  {0}", i);
            Console.WriteLine();
        }
    }
}