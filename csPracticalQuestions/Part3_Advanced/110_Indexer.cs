using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인덱서 (Indexer)는 인스턴스 내의 데이터에 접근하는 방법입니다. 용도는 속성(Property)과 똑같은데 다른 점은
// 배열과 같이 인텍스를 사용할 수 있다는 점입니다. 인덱서는 클래스나 구조체의 인스턴스를 배열처럼 인덱싱할 수 있게 합니다.
// 인덱서는 this[]를 사용하며 겟터와 셋터를 만듭니다. 겟터와 셋터에서 클래스의 어떤 값을 가져오고, 어떤 값을 세팅하는지 정해주면
// 됩니다. 예제를 통해 인텍서의 사용법을 살펴보겠습니다.
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

