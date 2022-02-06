using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Predicate <T> 델리게이트는 리턴 값이 반드시 bool이고 입력 파라미터가 하나인 델리게이트입니다. Predicate<T>는 Array나 List 클래스의
// 메소드들에서 자주 사용됩니다. 예를 들어 List<T> 클래스에서 Predicate<T>를 사용하는 메소드들은 다음과 같습니다.

// 리턴 타입 /      원형      / 설명
// bool      List<T>
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<String>
            {
                "mouse", "cow", "tiger", "rabbit", "dragon", "snake"
            };

            bool n = myList.Exists(s => s.Contains("x"));
            Console.WriteLine("이름에 'x'를 포함하는 동물이 있나요: " + n);

            Console.Write("이름이 3글자인 첫 번째 동물들: ");
            string name = myList.Find(s => s.Length == 3);
            Console.WriteLine(name);

            Console.Write("이름이 6글자 이상의 동물들: ");
            List<string> longName = myList.FindAll(s => s.Length > 5);
            foreach (var item in longName)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("대문자로 변환: ");
            List<string> capList = myList.ConvertAll(s => s.ToUpper());
            foreach(var item in capList)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}

