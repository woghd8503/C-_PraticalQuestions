using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Methods
    {
        static void Main(String[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine(today.ToString("yyyy년 mm월 dd일"));
            Console.WriteLine(string.Format("{0:yyyy년 mm월 dd일}", today));
            Console.WriteLine(today.ToString("MMMM dd, yyyy ddd", CultureInfo.CreateSpecificCulture("en-Us")));

            // d : 축약된 날짜 형식
            Console.WriteLine("d : " + today.ToString("d"));
            // D : 긴 날짜 형식
            Console.WriteLine("D : " + string.Format("{0:D}", today));
            // t : 축약된 시간
            Console.WriteLine("t : " + string.Format("{0:t}", today));
            // T : 긴 시간 형식
            Console.WriteLine("T : " + string.Format("{0:T}", today));
            // g : 일반 날짜 및 시간(초생략)
            Console.WriteLine("g : " + string.Format("{0:g}", today));
            // G : 일반 날짜 및 시간
            Console.WriteLine("G : " + string.Format("{0:G}", today));
            // f : full 날짜 및 시간(초생략)
            Console.WriteLine("f : " + string.Format("{0:f}", today));
            // s : ISO 8601 표준(밀리초 생략)
            Console.WriteLine("G : " + string.Format("{0:s}", today));
            // o : ISO 8601 표준
            Console.WriteLine("o : " + string.Format("{0:o}", today));
            // r : UTC로 표시 
            Console.WriteLine("r : " + string.Format("{0:r}", today));
            // u : UTC로 출력 
            Console.WriteLine("u : " + string.Format("{0:u}", today));
        }
    }
}


