using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     * String.Format()을 사용하면 콘솔에 출력하는 것과 똑같이 문자열에 저장할 수도 있다.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 100;
            double v2 = 1.234;

            // Console.WriteLine(v1, v2); // 에러가 발생
            Console.WriteLine(v1.ToString() + ", " + v2.ToString());
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");
        }
    }
}
