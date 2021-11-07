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
            //int[] intA = new int[4];
              
            //intA[0] = Int32.Parse(strA[0], 2);
            //int a = strA.Length;
            //int value = 21;
            //int value1 = Int32.Parse(Convert.ToString(value, 2));
            //Console.WriteLine(value1);

            int[] A = { 13, 7, 3 };
            int[] intA = new int[A.Length];
            int result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                //intA[i] = Int32.Parse(Convert.ToString(A[i], 2));
                intA[i] = Int32.Parse(Convert.ToString(A[i], 2));
            }

            for (int j = 0; j < A.Length -1; j++)
            {
                //result = intA[j] & intA[j + 1];
                result = A[j] & A[j + 1];

            }
            Console.WriteLine(result);
            result = Convert.ToInt32(result.ToString(), 2);
            
            Console.WriteLine(result);
        }
    }
}


