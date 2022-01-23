using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정수 배열에서 홀수와 짝수의 개수를 출력하는 프로그램이 있습니다.
// int[] arr = new int[] { 3, 5, 4, 2, 6, 4, 6, 8, 54, 23, 4, 6, 4 };
// Console.WriteLine("짝수의 개수: " + EvenCount(arr));
// Console.WriteLine("홀수의 개수: " + OddCount(arr));

// 홀수의 개수를 리턴하는 EvenCount() 메소드와 짝수의 개수를 리턴하는 OldCount() 메소드를 
// 나란히 써보았습니다.

// 
namespace ConsoleApp1
{
    class Program
    {
        delegate bool MemberTest(int a);

        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 4, 2, 6, 4, 6, 8, 54, 23, 4, 6, 4 };

            Console.WriteLine("짝수의 개수: " + Count(arr, IsEven));
            Console.WriteLine("홀수의 개수: " + Count(arr, IsOdd));
        }

        static int Count(int[] a, MemberTest testMethod)
        {
            int cnt = 0;
            foreach (var n in a)
            {
                if (testMethod(n) == true)
                    cnt++;
            }
            return cnt;
        }

        static public bool IsOdd(int n) { return n % 2 != 0; }
        static public bool IsEven(int n) { return n % 2 == 0; }
    }
}

