using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 일반화 프로그램은 데이터 형식을 일반화하는 기법으로 Generic Programming이라고 한다. 예를 들어 int배열의 요소들을 출력하는
// PrintArray(int[] a)메서드를 만들었다. 그런데 double 배열도 출력할 일이 생겼다. 이럴 때 어떻게 해야 될까?
// 메서드 중복을 배웠으므로 똑같은 메서드를 복사해서 매개변수만 바꾸어 PrintArray(doulbe[] a)메소드를 만들어 사용하면 된다.

// 더 좋은 방법으로는 일반화 프로그램이 있다. 메서드 중복으로 만든 두 개의 PrintArray() 메서드는 일반화 메소드로 만들면 하나로 처리가 가능하다.
// void PrintArray(int[] a) -> void PrintArray(double[] a) = void PrintArray<T>(T[] A) {...} // 일반화 메소드 정의
// T는 type이라는 뜻을 갖는 기호. 보통 T를 쓰지만 T 가 아니고 다른 문자를 써도 된다. <T>와 같이 꺽쇠 괄호 안에 T를 쓰면 T는 형식 매개변수가 되어
// int, doulbe 등의 형식으로 대치된다.

namespace Part3_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            double[] d = { 0.1, 0.2, 0.3 };
            string[] s = { "tiger", "lion", "zebra" };

            PrintArray<int>(a);
            PrintArray<double>(d);
            PrintArray<string>(s);
        }

        private static void PrintArray<T>(T[] a)
        {
            foreach (var item in a)
                Console.Write("{0,8}", item);
            Console.WriteLine();
        }
    }
}
