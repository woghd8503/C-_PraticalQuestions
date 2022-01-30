using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 앞장에서 배열에서 짝수와 홀수의 개수를 출력하는 프로그램을 델리게이트를 사용하여 작성했습니다.
// IsOdd()와 IsEven() 메소드는 MemberTest의 델리게이트 메소드로 사용되었습니다. 그런데 이 메소드들은
// 한번씩만 사용되었기 때문에 굳이 이름을 갖는 메소드로 정의하지 않고 이름 없이 인라인 함수로 만들 수 있습니다.
// 이것을 무명 또는 익명 델리게이트라고 합니다.
namespace ConsoleApp1
{
    class Program
    {
        delegate bool MemberTest(int x);

        static void Main(string[] args)
        {
            var arr = new[] { 3, 34, 6, 34, 7, 8, 24, 3, 675, 8, 23 };

            int n = Count(arr, delegate (int x) { return x % 2 == 0; });
            Console.WriteLine("짝수의 개수: " + n);

            n = Count(arr, delegate (int x) { return x % 2 != 0; });
            Console.WriteLine("홀수의 개수: " + n);
        }

        private static int Count(int[] arr, MemberTest testMethod)
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

