using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ 사용법을 조금 더 공부해 보겠습니다. 컬렉션에서 원하는 값을 찾는 과정이 마치 데이터베이스에서 질의하는 것과 같습니다. 이번엔
// 다음과 같은 문제를 풀어 보겠습니다. 

// (1) data 리스트에서 20보다 큰 짝수를 내림차순으로 정렬하여 저장
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

