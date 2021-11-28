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
            Console.Write("m!을 계산합니다. m를 입력하세요: ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", m, Fact(m));
        }

        private static double Fact(double x)
        {
            // 1! = 1, n! = n*(n-1)!
            if (x == 1)
                return 1;
            else
                return x * Fact(x - 1);
        }
    }
}


