using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 리스트와 배열은 만드는 방법과 사용하는 방법이 서로 다릅니다. 우선 List<T>와 Array는 객체 생성 방법이 다릅니다.

// List<string> lstNames = new LIst<string>();
// Array<string> arrNames = new Array<string>();  // 에러
// Array arrNames = new Array();                  // 에러

// List<T>는 위와 같이 new 키워드와 클래스 이름을 사용하여 만들지만 배열릉ㄴ 다음과 같이 만들어야 합니다.

// string[] arrName = new string[100];

// 정렬하는 메소드 Sort()는 List<T> 클래스에도 있고 Array 클래스에도 있습니다. 하지만 이 역시 사용 방법이 다릅니다.

// lstNames.Sort();
// arrNames.Sort(); // 에러

// 배열 이름 뒤에는 Sort() 메소드를 사용할 수 없습니다. Array 클래스의 Sort 메소드는 static으로 정의되어 있기 때문에 클래스의 이름과
// 함께 Array.Sort(배열이름) 형태로 사용합니다.

// Array.Sort(arrName);
// 리스트와 배열은 자료를 저장하는 가장 기본적인 자료구조입니다. 하지만 둘의 사용법이 다르다는 것을 기억해야 합니다.
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