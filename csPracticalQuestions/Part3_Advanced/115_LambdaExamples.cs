using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 람다식은 익명 메소드를 간단하게 표현할 수 있는 방법입니다. delegate, Func, Action으로 정의
// 된 메소드를 만들 수 있으며 "=>" 람다 연산자의 오른쪽에 식이 올 수도 있고 문장이 올 수도 있습니다.

// (1) 식 람다(Expression Lambda)
// 연산자의 오른쪽에 식이 있는 것을 식 람다라고 합니다. 식 람다는 식의 결과를 반환하며 기본 형식은 다음과 같습니다.
// (input-parameters) => expression
// 괄호는 람다 식에 입력 매개변수가 하나뿐인 경우에만 생략할 수 있고 그렇지 않으면 생ㄺ할 수 없습니다. 아래 예제에서
// (1) 입력 매개변수가 0개이면 빈 괄호를 지정합니다. (2) 둘 이상의 입력 매개변수는 괄호로 묶고 쉼표로 구분해야 합니다.
// (3) 컴파일러에서 입력 형식을 유추할 수 없는 경우에는 형식을 명시적으로 지정할 수 있습니다.

// Action line = () => Console.WriteLine();                                // (1)
// Func<int, int, bool> testForEquality = (x, y) => x == y;                // (2)
// Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;  // (3)

namespace ConsoleApp1
{
    class Program
    {
        delegate double CaLcMethod(double e, double b);
        delegate bool IsTeenAger(Student student);
        delegate bool IsAdult(Student student);

        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            Action line = () => Console.WriteLine();
            line();
            CaLcMethod add = (a, b) => a + b;
            CaLcMethod subtract = (a, b) => a - b;

            Console.WriteLine(add(10, 20));
            Console.WriteLine(subtract(10.5, 20));

            IsTeenAger isTeen = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

            Student s1 = new Student() { Name = "John", Age = 18 };
            Console.WriteLine("{0}은 {1}.", s1.Name, isTeen(s1) ? "청소년입니다" : "청소년이 아닙니다");

            IsAdult isAdult = (s) => { int adultAge = 18; return s.Age >= adultAge; };

            Student s2 = new Student() { Name = "Robin", Age = 20 };
            Console.WriteLine("{0}은 {1}.", s2.Name, isAdult(s2) ? "성인입니다" : "성인이 아닙니다");
            
        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; } 
        }
    }
}

