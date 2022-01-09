using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 리스트와 배열은 만드는 방법과 사용하는 방법이 서로 다릅니다. 우선 List<T>와 Array는 객체 생성 방법이 다릅니다.

// List<string> lstNames = new LIst<string>();
namespace ConsoleApp1
{
   class Program
    {
        static void Main(string[] args)
        {
            List<string> IstNames = new List<string>();
            IstNames.Add("dog");
            IstNames.Add("cow");
            IstNames.Add("rabbit");
            IstNames.Add("goat");
            IstNames.Add("sheep");
            IstNames.Sort();
            foreach (string s in IstNames)
                Console.Write(s + " ");
            Console.WriteLine();

            string[] arrNames = new string[100];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";
            Array.Sort(arrNames);
            foreach (string s in IstNames)
                Console.Write(s + " ");
            Console.WriteLine();
        }
    }
}