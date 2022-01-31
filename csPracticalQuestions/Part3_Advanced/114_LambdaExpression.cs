using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 람다식은 익명 메소드를 간단하게 표현할 수 있는 방법입니다. 람다식은 개체로 처리되는 코
// 드 블록( 식 또는 문 블록 )이며 메소드와 같이 매개변수와 리턴 값을 갖습니다. 람다식은 인수를
// 메소드에 전달할 수 있으며 값을 반환할 수 있습니다.

// 람다식은 델리게이    
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 3, 34, 6, 34, 7, 8, 24, 3, 675, 8, 23 };

            int n = Count(arr, x => x % 2 == 0);
            Console.WriteLine("짝수의 개수: " + n);

            n = Count(arr, x => x % 2 == 0);
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

