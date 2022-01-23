using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
=======
// Hashtable나 Dictionary<TKey, TValue> 객체는 사전과 같이 "키"와 "값" 쌍으로 데이터를 저장합니다. 0, 1, 2, ...와 같은 인덱스가 아니고 키에 의해 값을
// 찾아줍니다. Hashtable이나 Dictionary에서는 모든 값이 키가 될 수 있습니다. Hashtable은 non-generic 컬렉션이고 Dictionary<TKey, TValue>는 제레릭 컬렉션입니다.
// 사용법은 거의 같습니다. 여기서 TKey는 키의 타입, TValue는 값의 타입을 나타냅니다.

// Hashtable과 Dictionary는 키를 인덱스로 값을 찾아주기 때문에 탐색 속도가 O(1)입니다. 이 작업을 해싱(Hashing)이라고 합니다. Hashtable이라는 이름은 Hashing에서
// 유래한 것 입니다.

// 사용 시 주의해야 할 점이 있습니다.
// (1) 키는 중복될 수 없습니다. 중복된 키로 저장하면 ArgumentException이 발생합니다.
// (2) 없는 키로 Hashtable에 접근하면 KeyNotFoundException이 발생합니다.
// (3) 배열에서와 같은 순차적인 숫자 인덱스를 사용할 수 없습니다.
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 608ba215bfc3de8d4e7c4aaac694b089d5a04480
=======
>>>>>>> 608ba215bfc3de8d4e7c4aaac694b089d5a04480
=======
>>>>>>> 608ba215bfc3de8d4e7c4aaac694b089d5a04480
=======
>>>>>>> 608ba215bfc3de8d4e7c4aaac694b089d5a04480
=======
>>>>>>> 608ba215bfc3de8d4e7c4aaac694b089d5a04480
=======
>>>>>>> 608ba215bfc3de8d4e7c4aaac694b089d5a04480
=======
>>>>>>> 608ba215bfc3de8d4e7c4aaac694b089d5a04480
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

