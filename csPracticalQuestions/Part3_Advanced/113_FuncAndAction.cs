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
// .NET에서는 Func와 Action 델리게이트를 미리 만들어서 제공합니다. 이를 사용하면 delegate를 선언할
// 필요가 없습니다. Func 델리게이트는 결과를 반환하는 메소드를 참조하기 위해서, Action 델리게이트는
// 반환 값이 없는 메소드를 참조합니다.

// Func와 Action은 제너릭 매개변수를 사용합니다. 20번째 줄의 Func <int, bool> 은 매개변수로
// int 하나를 갖고 리턴 값이 bool인 델리게이트입니다. 매개변수 리스트 중에서 가장 뒤에 있는 것이
// 리턴 값이고 그 앞에 있는 매개변수들은 델리게이트 메소드의 매개변수 타입입니다. 매개변수가
// 없는 것부터 16개가 있는 것까지를 제공하므로 거의 모든 델리게이트를 Func와 Action으로 쓸 수 있습니다.

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

