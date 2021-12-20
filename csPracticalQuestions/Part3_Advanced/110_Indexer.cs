using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyCollection<T>
    {
        private T[] array = new T[100];

        public T this[int i] // 인덱서 정의
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myString = new MyCollection<string>();
            myString[0] = "Hello, World!";
            myString[1] = "Hello, C#";
            myString[2] = "Hello, Indexer!";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(myString[i]);
            }
        }
    }
}

