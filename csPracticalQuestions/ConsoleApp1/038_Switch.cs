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
        public enum Color { Red, Green, Blue };
        static void Main(string[] args)
        {
            Color c = (Color)(new Random()).Next(0, 3);
            if(c == Color.Red)
                Console.WriteLine("The color is red");
            else if (c == Color.Green)
                Console.WriteLine("The color is green");
            else if (c == Color.Blue)
                Console.WriteLine("The color is blue");
            else
                Console.WriteLine("The color is unknown");

            Console.WriteLine("점수를 입력하세요: ");
            int score = int.Parse(Console.ReadLine());
            string grade = null;

            if (score >= 90)
                grade = "A";
            else if (score >= 80)
                grade = "B";
            else if (score >= 70)
                grade = "C";
            else if (score >= 60)
                grade = "D";
            else
                grade = "F";

            Console.WriteLine("학점은 {0}", grade);

            switch (score / 10)
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }
            Console.WriteLine("학점은 {0}", grade);
        }
    }
}


