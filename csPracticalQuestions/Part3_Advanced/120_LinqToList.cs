using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 // LINQ의 결과는 IEnumerable <T>가 된다고 했습니다. LINQ의 결과를 리스트로 받고 싶으면 ToList<T>() 메소드를 사용합니다. 이와 비슷하게
 // LINQ의 결과를 배열로 받고 싶으면 ToArray<T>()메소드를 사용하면 됩니다.

// 다음의 프로그램은 리스트의 값 중에서 홀수를 찾아 정렬하여 리스트로 반환하고 짝수를 찾아 정렬하여 배열로 반환합니다.
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 };

            Print("data : ", data);

            var lstEven = from item in data
                          where (item > 20 && item % 2 == 0)
                          orderby item descending
                          select item;

            Print("20보다 큰 짝수 검색결과: ", lstEven);

            var lstSorted = from item in lstEven
                            orderby item ascending
                            select item * 2;

            Print("2를 곱해서 오름차순 정렬: ", lstSorted);
        }

        private static void Print(string s, IEnumerable<int> data)
        {
            Console.WriteLine(s);
            foreach (var i in data)
                Console.Write(" " + i);
            Console.WriteLine();
        }
    }
}

