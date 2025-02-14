﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 극장이나 음식점에서 순서를 기다리면서 줄을 서면 먼저 온 사람이 먼저 들어갑니다. 이와 같이 큐 (Queue)는 자료가
// 먼저 처리되므로 선입선출(FIFO, First-In First-Out)이라고도 합니다.

// 배열이나 리스트가 인덱스로 특정 위치의 자료에 자유롭게 접근하는 반면에, Queue는 입력은 오직 위에서, 출력은 앞에서만 이루어집니다. Queue에 자료를
// 넣는 것을 Enqueue, 꺼내는 것을 Dequeue라고 합니다.

// .NET 컬렉션은 제너릭 Queue<T>와 제네릭이 아닌 Queue를 제공합니다. 둘 중 Queue<T>의 사용을 권장합니다. Queue<T>의 사용 방법을 예제 프로그램으로 설명합니다.
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("Tiger");
            que.Enqueue("Lion");
            que.Enqueue("Zebra");
            que.Enqueue("Cow");
            que.Enqueue("Rabbit");
            PrintQueue("que: ", que);

            Console.WriteLine(" Dequeuing '{0}'", que.Dequeue());
            Console.WriteLine(" Peek: '{0}'", que.Peek());

            Queue<string> que2 = new Queue<string>(que.ToArray());
            PrintQueue("que2:", que2);

            string[] array = new string[que.Count];
            que.CopyTo(array, 0);
            Queue<string> que3 = new Queue<string>(array);
            PrintQueue("que3:", que3);

            Console.WriteLine("que.Contains(Lion) = {0}", que.Contains("Lion"));
            que3.Clear();
            Console.WriteLine("Count = {0}, {1}, {2}", que.Count, que2.Count, que3.Count);
        }

        private static void PrintQueue(string s, Queue<string> q)
        {
            Console.Write("{0,-8}", s);
            foreach(var item in q)
                Console.Write("{0,-8}", item);
            Console.WriteLine();
        }
    }
}

