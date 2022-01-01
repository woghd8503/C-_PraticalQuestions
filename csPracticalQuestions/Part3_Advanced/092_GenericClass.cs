using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 일반화 (제너릭)클래스는 멤버의 형을 <T>로 표시한 클래스이다. 객체 생성 시에 그 멤버의 형이 결정된다.
// 일반화 클래스 하나를 정의 
// class MyClass<T>
// {
//    public T x;
//    public T DoSomething(T p) { ... }
// }

// 클래스 이름 뒤의 <T>는 형식 매개변수라고 한다. 객체가 생성될 때 < > 안에 쓰는 형이 T를 대체하게 된다.
// 다음의 코드에서 x는 <int>를 사용했으므로 클래스의 정의에서 T로 쓴 부분이 int로 바귀게 되어 다음과 같은 클래스가
// 정의된 것과 같이 동작합니다. <string>을 쓴 두 번째 객체 s는 T가 string으로 바뀐 클래스를 사용하게 된다.
// MyClass<int> x = new MyClass<int>();
// MyClass<string> s = new MyClass<string>();
// 일반화 클래스를 사용하면 같은 구조와 동작을 갖지만 형만 다른 클래스를 중복해서 작성하지 않아도 된다.

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

