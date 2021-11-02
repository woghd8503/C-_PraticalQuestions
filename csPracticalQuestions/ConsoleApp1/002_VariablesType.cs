using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
      C#에서 제공하는 기본 자료형의 종류는 bool, byte, sbyte, char, decimal, double, float, int, uint, long, ulong, short, ushort, string 이 있다.
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요: ");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("키를 입력하세요(cm): ");
            float height = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("안녕하세요, ");
            Console.Write(name);
            Console.WriteLine("님!");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는 " );
            Console.Write(height);
            Console.WriteLine("cm 이군요!");
        }
    }
}
