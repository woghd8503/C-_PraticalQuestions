using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C#의 모든 배열은 System.Array 클래스를 상속받아 구현됩니다. 따라서 배열이 선언되면 System.Array 클래스의
// 속성과 메소드를 사용할 수 있습니다. System.Array 클래스의 주요 속성과 메소드는 아래와 같습니다. 속성은 괄호가
// 없고 메소드는 괄호가 있습니다. Array, Sort()와 같이 클래스 이름 Array와 함께 사용하는 메소드는 정적 메소드(static method)입니다.

// 속성 및 메소드                  설명
// Length               배열 요소의 총 개수
// Rank                 배열의 차수(차원)
// Array.Sort(a)        
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 25, 75, 35, 15 }; // 배열을 선언하고 초기화
            PrintArray(a);

            int[] b;
            b = (int[])a.Clone();   // 배열 복사 방법 1
            PrintArray(b);

            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 3);  // 배열 복사 방법 2
            PrintArray(c);

            a.CopyTo(c, 3);         // 배열 복사 방법 3
            PrintArray(c);

            Array.Sort(a);          // 오름차순으로 정렬
            PrintArray(a);

            Array.Reverse(a);        // 내림차순으로 정렬
            PrintArray(a);

            Array.Clear(a, 0, a.Length); // 배열을 초기화
            PrintArray(a);
        }

        private static void PrintArray(int[] a)
        {
            foreach(var i in a)
                Console.Write("{0,5}", i);
            Console.WriteLine();
        }
    }
}


