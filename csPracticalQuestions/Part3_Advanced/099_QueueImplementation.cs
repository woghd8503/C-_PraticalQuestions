using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5개의 랜덤 숫자를 큐에 저장하고, 세 개의 숫자를 꺼내어 출력하는 프로그램을 작성합니다.
// 큐에 값을 저장할 때는 EnQueue(), 꺼낼 때는 DeQueue()를 사용합니다.
namespace ConsoleApp1
{
   class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            MyQueue<float> que = new MyQueue<float>();

            for (int i = 0; i < 5; i++)
                que.EnQueue(new Node<float>(r.Next(100) / 100.0f));
            que.Print();

            for (int i = 0; i < 3; i++)
                Console.WriteLine("DeQueue: {0}", que.DeQueue());
            que.Print();
        }
    }
}