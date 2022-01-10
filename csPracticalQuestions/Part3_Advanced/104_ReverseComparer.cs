using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 컬렉션이란 같은 형의 데이터를 모아서 처리하는 자료구조입니다. 배열도 컬렉션의 하나입니다.
// 컬렉션에는 "제네릭 컬렉션"과 "제네릭이 아닌 컬렉션"의 두 가지 유형이 있습니다. .NET Framework 2.0에서
// 추가된 제네릭 컬렉션은 컴파일 타임에 형식이 안전한 type-safe 컬렉션을 제공합니다. 
// 이로 인해 제네릭 컬렉션은 일반적으로 성능이 더 뛰어납니다.

// (1)컬렉션의 공통 기능
// 모든 컬렉션은 항목 추가, 제거 또는 찾기를 위한 방법을 제공합니다.
// 컬렉션을 열거하는 기능 : 모든 컬렉션은 Enumerable 또는 IEunmerable<T> 인터페이스는 구현하므로 열거할 수 있고 foreach 문을 사용할 수 있습니다.
// IEnumerable <T>를 구현하는 모든 컬렉션은 LINQ를 사용하여 쿼리할 수 있습니다.
// 컬렉션의 내용을 배엻에 복사하는 기능 : CopyTo 메소드를 사용하면 컬렉션을 배열에 복사할 수 있습니다. 결과 배열은 항상 1차원이며 하한은 0입니다. 

// 그 외의 기능
// Capacity 및 Count 속성 : 컬렉션으 Capacity는 컬렉션에 포함할 수 있는 요소의 수이고, 컬렉션의 Count는 컬렉션에 실제로 포함되어 있는 요소의 수입니다.
// 대부분의 컬렉션은 현재 용량에 도달하면 자동으로 용량을 확장합니다.

// 일관된 하한 : 컬렉션의 하한은 첫 번째 요소의 인덱스입니다. System.Collections 네임스페이스의 모든 컬렉션은 하한이 0입니다. 즉 0부터 인덱싱됩니다.


namespace ConsoleApp1
{
    // 내림차순 정렬
    public class ReverseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;
            return string.Compare(s2, s1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] animalsEn = { "dog", "cow", "rabbit", "goat", "sheep", "mouse", "horse", "deer" };
            string[] animalsko = { "개", "소", "토끼", "염소", "양", "쥐", "말", "사슴" };
            Display("초기 배열", animalsEn);
            Array.Sort(animalsEn);
            Array.Reverse(animalsEn);
            Display("Sort()후 Reverse()", animalsEn);

            Display("초기 배열", animalsko);
            Array.Sort(animalsko, 2, 3);
            Display("[2]에서 3개 정렬 후", animalsko);

            IComparer revComparer = new ReverseComparer();

            Array.Sort(animalsko, revComparer);
            Display("내림차순 정렬", animalsko);
        }

        private static void Display(string comment, string[] arr)
        {
            Console.WriteLine(comment);
            for (int i = arr.GetLowerBound(0); i < arr.GetUpperBound(0); i++)
            {
                Console.Write("  {0}", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
