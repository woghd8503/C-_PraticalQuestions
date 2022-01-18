using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 큐와 반대로 스택은 나중에 저장된 자료가 먼저 처리될 때 사용하는 자료구조입니다. 나중에 들어온 자료가 먼저 처리되므로 후입선출(LIFO, Last-In Firts-Out)
// 이라고도 합니다. 스택은 입력과 출력이 한 방향에서만 이루어집니다. 스택에 자료를 넣는 것을 Push, 꺼내는 것을 Pop이라고 합니다.
// 큐와 마찬가지로 .NET 컬렉션은 Stack과 Stack <T>를 제공합니다. Stack 클래스는 제네릭이 아니고 (non-Generic), Stack<T>는 제너릭입니다.

// 예제 프로그램으로 Polish 표기법을 사용하는 4칙 계산기를 만들어 보겠습니다. Polish 표기법은 피연산자 뒤에 연산자를 쓰게 됩니다. 1 + 2를 1 2 +로 표시합니다.
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("계산할 수식을 Polish 표기법으로 입력하세요: ");
            string[] token = Console.ReadLine().Split();

            foreach (var i in token)
                Console.Write(" {0}", i);
            Console.Write(" = ");

            Stack<double> nStack = new Stack<Double>();
            foreach(var s in token)
            {
                if(isOperator(s))
                {
                    switch(s)
                    {
                        case "+":
                            nStack.Push(nStack.Pop() + nStack.Pop()); break;
                        case "-":
                            nStack.Push(-(nStack.Pop() - nStack.Pop())); break;
                        case "*":
                            nStack.Push(nStack.Pop() * nStack.Pop()); break;
                        case "/":
                            nStack.Push(1.0 / (nStack.Pop() / nStack.Pop())); break;
                    }
                }
                else
                {
                    nStack.Push(double.Parse(s));
                }
            }
            Console.WriteLine(nStack.Pop());
        }

        private static bool isOperator(string s)
        {
            if (s == "+" || s == "-" || s == "*" || s == "/")
                return true;
            else
                return false;
        }
    }
}

