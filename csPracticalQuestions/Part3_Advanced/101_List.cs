using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// List<T> 클래스는 C# 프로그래밍에서 동적으로 생성되고 삭제되는 자료를 저장할 때 가장 빈번하게 사용됩니다. 배열과 달리 크기가 가변이고, 제네릭 켈렉션이기
// 때문에 T에 어떠한 자료형도 넣을 수 있는 리스트입니다. 예를 들어 int의 리스트는 다음과 같이 생성합니다.
// List<int> list = new List<int>();

// List<T>는 제네릭 컬렉션이므로 System.Collections.Generic을 using 문으로 포함시켜서 사용합니다. 일반적으로 제네릭 컬렉션이 성능이 좋기 때문에 ArrayList를
// 쓸 경우가 있을 때에는 대신 List<T>를 사용하는 것이 권장됩니다. 참고로 제네릭 컬렉션에는 LinkedList<T>도 있습니다. 이름뿐 아니라 사용법도 비슷해서 List<T>와
// 혼동되는데, LinkedList<T>는 이중 연결 리스트입니다. 앞장의 예제를 List<T>로 바꾸어서 프로그램합니다.
namespace ConsoleApp1
{
   class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Random r = new Random();

            PrintValues(a);
            for (int i = 0; i < 10; i++)
                a.Add(r.Next(100));

            PrintValues(a);
            a.Sort();
            PrintValues(a);

            a.RemoveAt(3);
            PrintValues(a);
        }

        private static void PrintValues(List<int> a)
        {
            Console.WriteLine("Print Values in List<int>");
            Console.WriteLine("   Count = {0}", a.Count);
            Console.WriteLine("   Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write("   {0}", i);
            Console.WriteLine();
        }
    }
}