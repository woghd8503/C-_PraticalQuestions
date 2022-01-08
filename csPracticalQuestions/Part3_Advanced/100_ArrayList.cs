using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// 컬렉션이란 같은 형의 데이터를 모아서 처리하는 자료구조입니다. 배열도 컬렉션의 하나입니다. 컬렉션에는 "제네릭 컬렉션"과 "제네릭이 아닌 컬렉션"의 두 가지 유형이
// 있습니다. .NET Framework 2.0에서 추가된 제너릭 컬렉션은 컴파일 타임에 형식이 안전한(type-safe) 컬렉션을 제공합니다. 이로 인해 제네릭 컬렉션은 일반적으로 성능이
// 더 뛰어납니다.

// (1) 컬렉션의 공통 기능
// 모든 컬렉션은 항목 추가, 제거 또는 찾기를 위한 방법을 제공합니다.
// 컬렉션을 열거하는 기능 : 모든 컬렉션은 Enumerable 또는 IEnumerable<T> 인터페이스를 구현하므로 열거할 수 있고 foreach 문을 사용할 수 있습니다. IEnumerable <T>를 
// 구현하는 모든 컬렉션은 LINQ를 사용하여 쿼리할 수 있습니다.
// 컬렉션의 내용을 배열에 복사하는 기능 : CopyTo 메소드를 사용하면 컬렉션을 배열에 복사할 수 있습니다. 결과 배열은 항상 1차원이며 하한은 0입니다.

// 그 외의 기능
// Capacity 및 Count 속성 : 컬렉션의 Capacity는 컬렉션에 포함할 수 있는 요소의 수이고, 컬렉션의 Count는 컬렉션에 실제로 포함되어 있는 요소의 수입니다. 대부분의
// 컬렉션은 현재 용량에 도달하면 자동으로 용량을 확장합니다.
// 일관된 하한 : 컬렉션의 하한은 첫 번째 요소의 인덱스입니다. System.Collection 네임스페이스의 모든 컬렉션은 하한이 0입니다. 즉 0부터 인덱싱됩니다.

// 시나리오별 컬렉션 선택 기준
//                    수행할 작업                      /     Generic collection    /     Non-generic collection
// 키별로 빠르게 조회할 수 있도록 키/값 쌍으로 저장       /  Dictionary<TKey,TValue>  /             Hashtable
// 인덱스별로 항목 엑세스                               /  List<T>                  / Array, ArrayList
// FIFO(선입 선출) 방식으로 항목 사용                   /  Queue<T>                 / Queue
// LIFO(후입 선출) 방식으로 데이터 사용                 /  Stack<T>                  / Stack
// 순서대로 항목 엑세스                                /  LinkedList<T>             / -
// 컬렉션에 항목을 추가하거나 삭제할 때 알림 표시        /  ObservableCollection<T>   / -
// 정렬된 컬렉션                                      /  HashSet<T>, SortedSet<T>   / - 

// 컬력션의 예로 ArrayList를 사용해 보겠습니다. ArrayList는 이름에서 알 수 있듯이 배열과 유사한 컬렉션입니다. ArrayList의 가장 큰 장점은 배열과 달리 생성할
// 때 용량을 미리 지정할 필요없이 필요에 따라 자동으로 그 용량이 늘어나거나 줄어든다는 점입니다.
// ArrayList 클래스의 메소드는 20여개가 되지만 예제에서는 이중 많이 사용되는 Add(), RemoveAt(), Insert(), Sort()를 사용해 보겠습니다. Add()는 맨 뒤에 새 요소를
// 추가하고, RemoveAt()은 특정 인덱스에 있는 요소를 제거합니다. Insert()는 원하는 위치에 새 요소를 삽입하고 Sort()는 요소들을 정렬합니다.
// ArrayList에는 어떠한 값을 저장할 수 있을까요? 모든 타입의 값이 저장될 수 있습니다. ArrayList클래스의 메소드인 Add()를 보면 다음과 같이 정의되어 있습니다.
// public virtual int Add (object value);

// 즉, 매개변수로 object 타입을 가지고 있는데 C#의 모든 형신은 object를 상속받기 때문에 어떠한 형식의 데이터도 저장이 가능하게 되는 것입니다. 이것은 박싱(Boxing)과
// 언박싱(Unboxing)을 통해서 이루어집니다. 그런데 박싱과 언박싱은 시간이 요구되는 작업이므로 ArrayList가 다루는 데이터가 많아지면 프로그램의 실행 속도가 늦어지게 됩니다.
// 참고로 MSDN에서는 새로 프로그램을 작성할 때 ArrayList보다 성능이 우수한 List<T>를 사용하라고 추천하고 있습니다. ArrayList를 사용하여 100까지의 랜덤 정수 10개를
// 저장하고 정렬한 후 출력하는 프로그램을 작성해 보겠습니다.

namespace ConsoleApp1
{
   class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Random r = new Random();

            PrintValues(a);

            for (int i = 0; i < 10; i++)
                a.Add(r.Next(100));

            PrintValues(a);
            a.Sort();
            PrintValues(a);

            a.RemoveAt(3);
            PrintValues(a);
        }

        private static void PrintValues(ArrayList a)
        {
            Console.WriteLine("Print in ArrayList");
            Console.WriteLine("  Count = {0}", a.Count);
            Console.WriteLine("  Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write("  {0}", i);
            Console.WriteLine();
        }
    }
}