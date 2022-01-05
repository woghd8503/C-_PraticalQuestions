using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 선입선출(Fast-in-first-out, FIFO) 형태의 자료를 다룰 때는 큐를 사용합니다. 선착순으로 제일 먼저 들어온 자료가
// 제일 먼저 들어온 자료가 제일 먼저 나가는 자료구조입니다. C#의 컬렌션에는 Queue <T>가 있어서 큐가 필요하면 .NET에서 제공되는 Queue<T>를 쓰면 됩니다.
// 하지만 이번 장에서는 직접 큐를 만들겠습니다. 컬렉션에서 제공하는 Queue <T>와 구분하기 위해서 MyQueue <T>를 만듭니다. 프로젝트는 Main()이 있는 Program
// 클래스가 있는 program.cs와 MyQueue <T>클래스를 정의하는 myQueue.cs 파일 두 개로 구성합니다.

// Queue.cs  파일에서 MyQueue <T> 클래스를 정의합니다. 큐에 저장되는 값이 여러 가지 타입일 수 있으므로 제너릭으로 정의합니다. MyQueue <T> 클래스에는 큐의
// 맨 앞과 맨 뒤를 가리키는 first와 last 필드를 갖습니다. 각각의 자료는 Node <T>로 저장되므로 Node <T> 클래스도 정의합니다. MyQueue <T> 클래스의 메소드는
// 값을 추가하는 EnQueue()와 값을 삭제하는 DeQueue()가 있습니다. 큐에 대한 자세한 설명은 생략하겠습니다.

// first : 큐의 첫 번째 요소를 가리키는 참조입니다.
// last : 큐의 마지막 요소를 가리키는 참조입니다.
// EnQueue() : 큐에 값을 추가합니다.
// DeQueue() : 큐에서 값을 삭제합니다.
// Print() : 큐의 내용을 입력된 순서로 출력합니다.
namespace ConsoleApp1
{
    class Node<T>
    {
        internal T value;
        internal Node<T> next;

        public Node (T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    class MyQueue<T>
    {
        internal Node<T> first = null;
        internal Node<T> last = null;

        internal void EnQueue(Node<T> node)
        {
            if (last == null)
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
        }

        internal T DeQueue()
        {
            if (first == null)
            {
                Console.WriteLine("Queue Empty");
                return default(T);
            }
            else
            {
                T value = first.value;
                first = first.next;
                return value;
            }
        }

        internal void Print()
        {
            for (Node<T> t = first; t != null; t = t.next)
                Console.Write(t.value + " -> ");
            Console.WriteLine();
        }
    }
}