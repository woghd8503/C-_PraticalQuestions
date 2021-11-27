using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Methods
    {
        static void Main(String[] args)
        {
            int a = 10, b = 30, c = 20;
            int[] a1 = new int[3];
            Methods x = new Methods();
            Console.WriteLine("1. 가장 큰 수는 {0}\n", x.Larger(x.Larger(a, b), c));

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i+1}번째 숫자를 입력하세요: ");                
                a1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n2. 가장 큰 수는 {0}", Larger1(Larger1(a1[0], a1[1]), a1[2]));
        }

        private int Larger(int a, int b)  // static이 아닙니다.
        {
            return (a >= b) ? a : b;
        }

        private static int Larger1(int a, int b)
        {
            return (a >= b) ? a : b;
        }
    }
}


