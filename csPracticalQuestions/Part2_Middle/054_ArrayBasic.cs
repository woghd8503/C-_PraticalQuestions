using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 배열은 같은 자료형을 같는 자료들의 연속된 집합입니다 C#에서 배열은 참조형이므로 다음과 같이 new 키워드를 사용
// 하여 생성합니다.

// 자료형[] 배열명 = new 자료형[N];  // N은 배열의 크기

// 배열은 선언과 동시에 초기화할 수 있습니다. 중괄호 안에 배열 원소들을 나열하면 됩니다. 초기화할 때는 배열의 개수가
// 중괄호 안에 있는 자료의 숫자이므로 배열의 크기를 명시하지 않아도 됩니다. 다음은 배열을 초기화하는 세 가지 방법입니다.

// 자료형[] 배열명 = {자료1, 자료2, ... };
// 자료형[] 배열명 = new 자료형[] {자료1, 자료2, ... };
// 자료형[] 배열명 = new 자료형[N] {자료1, 자료2, ..., 자료N };

// 배열 안에 들어 있는 각각의 자료를 요소(element)라고 합니다. 배열의 요소를 지정할 때는 대괄호 안에 숫자 인덱스를
// 사용합니다. 크기가 N인 배열의 요소는 0부터 N-1까지의 인덱스로 지정합니다. 즉 배열 a[]의 첫 요소는 a[0], 두 번째
// 요소는 a[1], 맨 마지막 요소는 a[N-1]가 됩니다. 만약 a[N]을 사용하면 IndexOutOfRangeException이 발생합니다.

// 배열이나 리스트와 같은 데이터들을 모아 놓은 것을 컬렉션(collection)이라고 합니다. 컬렉션은 foreach 반복문을 사용하면
// 편리합니다. foreach (var value in a)는 "a 컬렉션의 각 요소값 value에 대해서" 라는 뜻입니다. 여기서 var는 어떤 자료형에도
// 쓸 수 있는 키워드입니다.


  
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


