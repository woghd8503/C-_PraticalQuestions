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
    class MyClass<T>
    {
        private T[] arr;
        private int count = 0;

        public MyClass(int length)
        {
            arr = new T[length];
            count = length;
        }

        public void Insert(params T[] args)
        {
            for (int i = 0; i < args.Length; i++)
                arr[i] = args[i];
        }

        public void Print()
        {
            foreach (T i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        public T AddAll()
        {
            T sum = default(T);
            foreach (T item in arr)
                sum = sum + (dynamic)item;
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> a = new MyClass<int>(10);
            MyClass<string> s = new MyClass<string>(5);

            a.Insert(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            s.Insert("Tiger", "Lion", "Zebra", "Monkey", "Cow");

            a.Print();
            s.Print();

            Console.WriteLine("a.AddAll() : " + a.AddAll());
            Console.WriteLine("s.AddAll() : " + s.AddAll());
        }
    }
}

