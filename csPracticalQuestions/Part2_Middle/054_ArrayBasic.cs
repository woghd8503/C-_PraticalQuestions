using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 배열은 같은 자료형을 같는 자료들의 연속된 집합입니다 C#에서 배열은 참조형이므로 다음과 같이 new 키워드를 사용
// 하여 생성합니다.

// 자료형[] 배열명 = new 자료형[N];  // N은 배열의 크기

// 배열은 선언과 동시에 초기화할 수 있습니다. 중괄호
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            Console.Write("a[]: ");
            foreach (var value in a)
                Console.Write(value + " ");

            int[] b = new int[] { 1, 2, 3 };
            Console.Write("\nb[]: ");
            for( int i = 0; i < 3; i++)
                Console.Write(b[i] + " ");

            int[] c = new int[] { 1, 2, 3 };
            Console.Write("\nc[]: ");
            for(int i = 0; i < c.Length; i++)
                Console.Write(c[i] + " ");

            int[] d = new int[3];
            d[0] = 1;
            d[1] = d[0] + 1;
            d[2] = d[1] + 1;
            Console.Write("\nd[]: ");
            foreach (int value in d)
                Console.Write(value + " ");
            Console.WriteLine();
        }
    }
}


