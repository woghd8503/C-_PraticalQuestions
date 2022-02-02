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

// 람다식은 델리게이트로 표현될 수 있는 코드입니다. 람다식의 델리게이트형은 리턴 값이나 파라미터 개수에
// 따라 정해집니다. 리턴 값이 없는 람다식은 Action 델리게이트에 해당하고 리턴값이 있는 람다식은 Func
// 델리게이트에 해당합니다. 두 개의 파라미터를 갖고 리턴 값이 없는 람다식은 Action <T1, T2>델리게이트에 해당합니다.
// 한 개의 파라미터와 리턴 값을 갖는 람다식은 Func <T, TResult> 델리게이트에 해당합니다. 람다식은 람다 연산자 "=>"로
// 표현됩니다. => 연산자 왼쪽은 매개변수, 오른쪽은 식, 또는 문장이 위치하는데 이것이 리턴 값이 됩니다. 예를 들어 x => x * x
// 는 매개변수 x에 대해 x의 제곱을 리턴하는 람다식입니다. 익명 메소드는 delegate로 만들고 메소드 이름이 없이 사용됩니다.
// C#3.0부터 람다식이 도입되면서 익명메소드를 쓸 일이 없어졌습니다. 람다식이 훨씬 간단하기 때문입니다. 앞장에서
// 사용했던 익명 메소드 부분입니다.

// int n = Count(arr, delegate (int x)) {return x % 2 == 0; });

// 이를 람다식으로 표현하면 다음과 같이 쓸 수 있습니다.
// int n = Count(arr, x => x % 2 == 0);

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

