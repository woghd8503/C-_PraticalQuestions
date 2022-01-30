using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 앞장에서 배열에서 짝수와 홀수의 개수를 출력하는 프로그램을 무명 델리게이트를 사용하여 작성했습니다.
// 델리게이트를 사용하려면 우선 delegate를 선언해야 하는데 이것도 사실은 번거로운 일입니다.

namespace ConsoleApp1
{
    class Program
    {
       // delegate bool MemberTest(int x); // Func를 사용하므로 필요 없음

        static void Main(string[] args)
        {
            var arr = new[] { 3, 34, 6, 34, 7, 8, 24, 3, 675, 8, 23 };

            int n = Count(arr, delegate (int x) { return x % 2 == 0; });
            Console.WriteLine("짝수의 개수: " + n);

            n = Count(arr, delegate (int x) { return x % 2 != 0; });
            Console.WriteLine("홀수의 개수: " + n);
        }

        private static int Count(int[] arr, Func<int, bool> testMethod)
        {
            int cnt = 0;
            foreach (var n in arr)
            {
                if (testMethod(n))
                    cnt++;
            }
            return cnt;
        }
    }
}

