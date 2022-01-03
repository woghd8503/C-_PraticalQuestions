using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C#은 강력한 형식 검사를 하는 언어이다. 그래서 일반화 클래스에서 <T>로 정의된 값들은 더하거나 비교하는 부분에서
// 컴파일 시에 에러 메서지가 나온다. 왜냐하면 <T>는 사용자가 만든 클래스를 포함해서 어떠한 자료형도 올 수 있는데
// 이 자료들이 더하거나 비교할 수 있는 데이터인지 알 수 없기 때문이다.

// 이 문제를 dynamic 키워드로 처리할 수 있다. dynamic형은 형식 검사를 컴파일 시에 하지않고 실행할 때 한다. 실행할 때는
// <T>에 대치되는 int, doulbe 등의 형식이 사용되고 이런 데이터들이 더하거나 비교할 수 있기 때문에 에러가 발생하지 않는다

// 저장하는 데이터의 형이 int, double, float, decimal 등 어떤 숫자형 배열이라도 적용할 수 있는 메소드를 dynamic과 일반화
// 프로그램으로 작성한다. 만들어야 할 메소드는 배열에서 합계, 평균, 최대값을 찾는 메소드이다.

namespace Part3_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 45, 32, 47, 85, 46, 93, 47, 50, 71 };
            double[] d = { 0.1, 5.3, 6.7, 8.5, 4.9, 6.1 };
            float[] f = { 1.2f, 5.3f, 7.8f, 6.1f, 3.4f, 8.8f };
            decimal[] c = { 123, 783, 456, 234, 456, 748 };

            PrintArray<int>("a[] :", a);
            CalcArray<int>(a);
            PrintArray<double>("d[] :", d);
            CalcArray<double>(d);
            PrintArray<float>("f[] :", f);
            CalcArray<float>(f);
            PrintArray<decimal>("c[] :", c);
            CalcArray<decimal>(c);
        }

        private static void CalcArray<T>(T[] a) where T: struct
        {
            T sum = default(T);
            T avg = default(T);
            T max = default(T);

            foreach(dynamic item in a)
            {
                if (max < item)
                    max = item;
                sum += item;
            }
            avg = (dynamic)sum / a.Length;
            Console.WriteLine("      Sum = {0}, Average = {1}, Max = {2}", sum, avg, max);
        }

        private static void PrintArray<T>(string s, T[] a) where T: struct
        {
            Console.Write(s);
            foreach(var item in a)
            {
                Console.Write(" {0}", item);
            }
            Console.WriteLine();
        }
    }
}

