using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 배열을 정렬할 때는 Array.Sort() 메소드를 사용합니다. Sort() 메소드는 디폴트로 오름차순으로 정렬합니다. 그렇다면 내림차순으로 정렬
// 할 때는 어떻게 할까요?

// 첫 번째 방법은 오름차순으로 정렬한 후, 배열의 내용을 뒤집어주면 됩니다. 즉 Array 클래스의 Sort() 메소드를 사용하여 정렬된 배열을
// 만든 후에, Reverse()메소드를 사용합니다.

// int[] arr = {12, 32, 43, 24, 8};
// Array.Sort(arr);                 // 오름차순으로 정렬
// Array.Reverse(arr);              // 배열의 내용을 뒤집어 줌 

// 두 번재 방법은 Sort() 메소드의 IComparer 인터페이스를 구현해 주는 것입니다. Array 클래스의 Sort() 메소드는 다양한 방법으로 중복되어
// 있습니다. 대표적으로 다음과 같은 세 가지 Sort() 메소드를 살펴보겠습니다.

// public static void Sort(Array);                // (1) 오름차순 정렬
// public static void Sort(Array, Int32, Int32)   // (2) 인텍스와 개수에 의한 정렬
// public static void Sort(Array, IComparer);     // (3) IComparer에 의한 정렬

// (1)번 방법은 가장 기본적인 오름차순 정렬 방법입니다. (2)번 방법은 정려한 인덱스와 개수를 지정하는 방법입니다. 예를 들어 Array.Sort(arr, 2, 3)
// 이라고 하면 배열의 2번 인텍스부터 3개의 요소만을 정렬해줍니다. (3)번 방법이 지금 사용할 수 있는 방법입니다. 즉, IComparer 인터페이스를 구현하여
// 이 규칙에 따라 정렬하는 것입니다. ICopmarer 인터페이스는 다음과 같이 public int Compare() 메소드를 만들게 되어 있습니다. 
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
