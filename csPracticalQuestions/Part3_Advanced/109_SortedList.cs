using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SortedList 컬렉션은 키의 오름차순으로 키-값 쌍으로 저장합니다. 내부적으로 SortedList는 키와 값을 저장하는 두 개의 object[] 배열을 유지합니다.
// 새로운 값이 들어오면 키를 이진탐색하여 적절한 인덱스를 찾고 그 곳에 키-값 쌍을 저장합니다.

// C#은 제네릭이 아닌 SortedList와 제네릭 SortedList<TKey,TValue>의 두 가지 SortedList를 제공합니다. 제네릭 SortedList<TKey,TValue>에서 TKey는
// 키의 타입이고 TValue는 값의 타입입니다. 제네릭이 아닌 SortedList에서는 키와 값의 타입을 지정하지 않습니다.
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> s1 = new SortedList<int, string>();
            s1.Add(3, "Tree");
            s1.Add(4, "Four");
            s1.Add(1, "One");
            s1.Add(2, "Two");

            for (int i = 0; i < s1.Count; i++)
                Console.Write("k: {0}, v: {1} / ", s1.Keys[i], s1.Values[i]);
            Console.WriteLine();

            foreach(var kvp in s1)
                Console.Write("{0, -10} ", kvp);
            Console.WriteLine();

            SortedList<String, int> s2 = new SortedList<string, int>();
            s2.Add("one", 1);
            s2.Add("two", 2);
            s2.Add("three", 3);
            s2.Add("four", 4);

            Console.WriteLine(s2["two"]);

            foreach (var kvp in s2)
                Console.Write("{0, -10} ", kvp);
            Console.WriteLine();

            int val;
            if (s2.TryGetValue("ten", out val))
                Console.WriteLine("key: ten, value: {0}", val);
            else
                Console.WriteLine("[ten] : key is not valid.");

            if (s2.TryGetValue("one", out val))
                Console.WriteLine("key: one, value: {0}", val);

            Console.WriteLine(s2.ContainsKey("one"));  // returns true
            Console.WriteLine(s2.ContainsKey("ten"));  // return false
            Console.WriteLine(s2.ContainsValue(2));    // return true
            Console.WriteLine(s2.ContainsValue(6));    // return false

            s2.Remove("one"); // 키가 'one'인 요소 삭제
            s2.RemoveAt(0);   // 첫 번째 요소 삭제

            foreach (KeyValuePair<string, int> kvp in s2)
                Console.Write("{0, -10} ", kvp);
            Console.WriteLine();
        }
    }
}

