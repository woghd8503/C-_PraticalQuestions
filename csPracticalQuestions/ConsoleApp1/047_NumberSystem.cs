using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string plain = Console.ReadLine();

            

            int answer = 0;
            int first = 0;
            int last = plain.Length;
            int middle = 0;


            if (plain.Length % 2 == 0)
                middle = plain.Length / 2;
            else
                middle = (plain.Length + 1) / 2;

            while (plain[first] != plain[last -1])
            {
                plain = plain + plain[middle];
                middle -= 1;
            }

            answer = plain.Length;

            Console.WriteLine(answer);
        }
    }
}


