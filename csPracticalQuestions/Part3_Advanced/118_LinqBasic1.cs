using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ는 Language-INtegrated Query의 약자로 C#에 통합된 데이터 질의 기능입니다. SQL과 같은 Query 언어는 데이터베이스에서 사용되던 언어인데,
// 이를 C#에 도입한 것입니다. LINQ를 사용하면 컬렉션에서 데이터를 다루는 방법이 훨신 간단해집니다. LINQ는 람다와 함께 C# 3.0에 도입된 기능입니다.

//
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 };
            List<int> lstSortedEven = new List<int>();

            foreach (var item in data)
            {
                if (item % 2 == 0)
                    lstSortedEven.Add(item);
            }
            lstSortedEven.Sort();

            Console.WriteLine("Using foreach: ");
            foreach (var item in lstSortedEven)
                Console.Write(item + " ");
            Console.WriteLine();

            var sortedEven = from item in data
                             where item % 2 == 0
                             orderby item
                             select item;

            Console.WriteLine("\nUsing Linq: ");
            foreach (var item in sortedEven)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}

