using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     * [암시적 형변환]
     * float를 double로 형변환하는 경우처럼 작은 자료형을 더 큰 자료형으로 변환할 때는 데이터의 손실이 생기지 않는다. 
     * 
     * [명시적 형변환]
     * 반대로 double에서 int로 변환하는 경우처럼 큰 자료형을 작은 자료형으로 변환할 때는 데이터가 손실 될 수 있다. 강제 형변환
     * 명시적 형변환을 위해서는 변환하고자 하는 자료형으로 기존 자료형을 캐스트(cast)해준다. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            long bigNum = num; // 암시적 형변환
            Console.WriteLine(bigNum);

            double x = 1234.5;
            int a;

            a = (int)x;        // 명시적 형변환
            Console.WriteLine(a);
        }
    }
}
