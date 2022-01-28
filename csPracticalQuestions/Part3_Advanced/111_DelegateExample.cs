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

// static int EvenCount(int[] a)                static int OddCount(int[] a)
// {                                            {
//   int cnt = 0;                                 int cnt = 0;
//   foreach (var n in a)                         foreach (var n in a)
//   {                                            {
//     if (n % 2 == 0)                              if (n % 2 == 1)
//       cnt++;                                       cnt++;
//   }                                            }
//   return cnt;                                  return cnt;
// }                                            }

// 두 메소드를 보면 n%2가 0인지 1인지를 판단하는 if 문만 다르고 완전히 똑같은 코드입니다.
// 이것을 하나로 만들 수는 없을까요? 이럴 때 사용하는 것이 델리게이트입니다. 델리게이트는 대리자라는 뜻으로 메소드의 참조,
// 즉 C언어의 함수 포인터와 같은 개념입니다. 델리게이트는 다음과 같이 선언합니다. delegate 키워드를 제외하면 메소드의 선언과
// 똑같습니다. 
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

