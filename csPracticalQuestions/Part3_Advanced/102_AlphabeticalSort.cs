using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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