using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 실행 중에 나오는 예외(Exception)라고 한다. 산술 연산에서 나올 수 있는 예외는 0으로 나눔 예외(DivideByZeroException)와
    // 오버플로우 예외(OverflowException)이다.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
            int x = int.MaxValue, y = 0;
            y = x + 10;
            Console.WriteLine("int.MaxValue + 10 = {0}", y);


            // y = int.MaxValue + 10;
            
            checked
            {
                try
                {
                    y = x + 10;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    }
}
