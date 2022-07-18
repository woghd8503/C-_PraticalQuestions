using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Console.WriteLine("World!");
            Console.WriteLine("이름을 입력하세요: ");

            string name = Console.ReadLine();        // 이름을 입력받습니다.
            Console.WriteLine("안녕하세요, ");
            Console.WriteLine(name);
            Console.WriteLine("님!");
        }
    }
}
