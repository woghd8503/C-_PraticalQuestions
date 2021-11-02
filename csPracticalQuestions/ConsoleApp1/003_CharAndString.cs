using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     [문자와 문자열의 차이점]
      1. 기본 데이터 형식 중 하나인 char 는 영문자, 숫자, 한글 등 UTF-16으로 코딩된 문자 하나를 저장할 수 있다. 
      2. 'A' 와 "A" 는 완전히 다른 의미를 갖습니다. A 는 변수명이고 'A' 는 문자 Char, "A" 는 문자열 String 을 의미 

     [string 의 개별 문자에 대한 읽기 전용 엑세스를 위해 [] 연산자를 사용]
      string str = "test";
      char x = str[2];   // x = 's';

     [이스케이프 시퀀스]
      1. 백슬러시 (\) 뒤에 한 문자난 숫자가 오는 문자 조합을 "이스케이프 시퀀스"라고 함.
      2. 줄 바꿈 문자('\n'), 따옴표('\"), 탭('\t')
      3. 백슬러시(\)를 출력하고 싶다면 백슬래시 두 개(\\)를 써야 됨.
      4. 겹 따옴표(") 앞에 @를 쓰면 이스케이프 시퀀스를 무시
         string b = @"c:\Docs\Source\a.txt";      // "c:\Docs\Source\a.txt"와 동일
      5. string 타입의 변수에 사용되는 3가지 연산자
         a == b string a와 b가 같다 / a != b string a와 b가 같지 않다 / a + b string a와 b를 연결한다. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "h";

            b = b + "ello";
            Console.WriteLine(a == b);
            Console.WriteLine("b = " + b);

            int x = 10;
            string c = b + '!' + " " + x;
            Console.WriteLine("c = " + c);
        }
    }
}
