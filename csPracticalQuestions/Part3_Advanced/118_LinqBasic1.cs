using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ는 Language-INtegrated Query의 약자로 C#에 통합된 데이터 질의 기능입니다. SQL과 같은 Query 언어는 데이터베이스에서 사용되던 언어인데,
// 이를 C#에 도입한 것입니다. LINQ를 사용하면 컬렉션에서 데이터를 다루는 방법이 훨신 간단해집니다. LINQ는 람다와 함께 C# 3.0에 도입된 기능입니다.

// var sortedEven = from item in data
//      where item % 2 == 0;
//      order item
//      select item;

// 위의 문장을 보면 from, where, orderby, select 등의 LINQ 연산자가 사용되었습니다. "data 컬렉션에 있는 데이터 item으로부터 item이 짝수이면
// item 값으로 정렬하여 선택한다." 라는 뜻입니다. LINQ를 사용하려면 원본 데이터가 IEnumerable이나 IEnumerable<T> 인터페이스를 상속하는 형식이어야"
// 합니다. 배열과 리스트 등의 컬렉션들은 모두 여기에 해당됩니다. 

// 다음의 예제는 List에서 짝수 데이터만을 꺼내어 정렬하여 출력하는 프로그램을 기존 방법과 LINQ를 사용하는 두 가지 방법으로 작성했습니다.
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 };
            List<int> lstSortedEven = new List<int>();

            foreach (var item in data)
            {
                if (item % 2 == 0)
                    lstSortedEven.Add(item);
            }
            lstSortedEven.Sort();

            Console.WriteLine("Using foreach: ");
            foreach (var item in lstSortedEven)
                Console.Write(item + " ");
            Console.WriteLine();

            var sortedEven = from item in data
                             where item % 2 == 0
                             orderby item
                             select item;

            Console.WriteLine("\nUsing Linq: ");
            foreach (var item in sortedEven)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}

