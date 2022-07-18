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
            Console.WriteLine("10 이하의 소수: {0}, {1}, {2}, {3}", 2, 3, 5, 7);

            string primes;
            primes = String.Format("10 이하의 소수: {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}
