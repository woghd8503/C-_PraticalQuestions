using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Predicate <T>는 Func나 Action과 같은 미리 정의된 델리게이트 형식입니다. Predicate 델리게이트 메소드는 하나의 매개변수를 갖고 리턴 값이
// bool인 델리게이트입니다. 다음의 소스코드를 보면서 Predicate를 알아보겠습니다. 

// Predicate<int> isEven = IsEven;
//
// Static bool IsEven(int n)
// {
//    return n % 2 == 0;
// }

// Predicate<int> isEven은 매개변수가 정수 하나이고 리턴 값이 bool인 IsEven 메소드의 이름을 지정합니다. 여기서 Predicate isEven는
// 소문자로 시작하고 메소드 IsEeven() 메소드를 호출할 수 있습니다.

// Console.WriteLine(isEven(6)); // 결과: true

// 여기서 Predicate 대신 Func <int, bool> isEven = IsEven;를 써도 Predicate는 리턴 값이 bool로 정해져 있으므로 같은 결과가 나옵니다.
// IsEven(int n) 메소드를 람다식으로 변형하면 다음과 같이 한 줄로 쓸 수 있습니다.

// static bool IsEven(int n) => n % 2 ==0;

// 또 IsEven() 메소드를 익명 델리게이트로 쓴다면 함수를 정의하지 않고, Predicate 선언 부분에 직접 쓸 수 있습니다.

// Predicate<int> isEven = n => n % 2 == 0;
// 코드를 보면 정말 간단합니다.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;
            Console.WriteLine(isEven(6));

            Predicate<string> isLowerCase = s => s.Equals(s.ToLower());
            Console.WriteLine(isLowerCase("This is test"));
        }
    }
}

