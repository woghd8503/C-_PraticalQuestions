using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyStack<T>
    {
        const int maxSize = 10;
        private T[] arr = new T[maxSize];
        private int top;

        public MyStack()
        {
            top = 0;
        }

        public void Push(T val)
        {
            if (top < maxSize)
            {

            }
        }
      static void Main(string[] args)
        {
            
        }
    }
}