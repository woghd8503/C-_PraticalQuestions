using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Hashtable나 Dictionary<TKey, TValue> 객체는 사전과 같이 "키"와 "값" 쌍으로 데이터를 저장합니다. 0, 1, 2, ...와 같은 인덱스가 아니고 키에 의해 값을
// 찾아줍니다. Hashtable이나 Dictionary에서는 모든 값이 키가 될 수 있습니다. Hashtable은 non-generic 컬렉션이고 Dictionary<TKey, TValue>는 제레릭 컬렉션입니다.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> colorTable = new Dictionary<string, string>();

            colorTable.Add("Red", "빨간색");
            colorTable.Add("Green", "초록색");
            colorTable.Add("Blue", "파란색");

            foreach (var v in colorTable)
                Console.WriteLine("colorTable[{0}] = {1}", v.Key, v.Value);

            try
            {
                colorTable.Add("Red", "빨강");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Yellow => {0}", colorTable["Yellow"]);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n" + colorTable["Red"]);
            Console.WriteLine(colorTable["Green"]);
            Console.WriteLine(colorTable["Blue"]);
        }
    }
}

