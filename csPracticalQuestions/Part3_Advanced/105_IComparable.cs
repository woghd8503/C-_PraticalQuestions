using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C#의 컬렉션은 대부분 Sort 메소드를 제공하는데 다음과 같이 IComparable 인터페이스를 구현해야 정상적으로 동작합니다. ICompable 인터페이스에는
// 자신과 비교할 매개변수를 비교하여 결과를 반환하는 CompareTo 메소드를 만들도록 약속하고 있습니다. 매개변수 형식이 object 형식으로 되어 있으므로
// 프로그램 목적에 맞게 캐스팅하여 처리해야 합니다.

// interface IComparable
// {
//    int CompareTo(object obj);
// }

// C#의 System에 정의되어 있는 int, double, string 등의 기본 형식들은 ICompable 인터페이스를 기반으로 정의되어 있어서 이들 기본 형식을 보관한 컬렉션은
// Sort 메소드를 이용하여 정렬할 수 있습니다. 사용자가 정의한 클래스나 구조체는 여러 필드나 속성을 포함할 수 있으므로 어떤 기준으로 정렬할 지를 사용자가
// 지정해야 합니다. 사용자가 클래스를 정의할 때 IComparable 인터페이스 기반으로 정의하고 CompareTo 메소드를 정의하면 객체의 컬렉션에서 Sort 메소드를
// 사용할 수 있습니다. 다음의 예제는 미술가들을 태어난 년도를 기준으로 정렬하는 방법을 보여줍니다.
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Artists[] famousArtists =
            {
                new Artists("레오나르도 다빈치", "이탈리아", 1452, 1519),
                new Artists("빈센트 반 고흐", "네덜란드", 1852, 1890),
                new Artists("클로드 모네", "프랑스", 1840, 1926),
                new Artists("파블로 피카소", "스페인", 1881, 1973),
                new Artists("베르메르", "네덜란드", 1632, 1675),
                new Artists("르노아르", "프랑스", 1841, 1919)
            };

            List<Artists> artists19C = new List<Artists>();
            foreach (var artist in famousArtists)
            {
                if (artist.Birth > 1800 && artist.Birth <= 1900)
                    artists19C.Add(artist);
            }

            // IComparable를 사용하여 정렬
            artists19C.Sort();
            Console.WriteLine("19세기 미술가를 탄생 순 정렬: IComparable");
            foreach (var a in artists19C)
                Console.WriteLine(a.ToString());
        }
    }

    class Artists : IComparable
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Birth { get; set; }
        public int Die { get; set; }

        public Artists(string name, string country, int birth, int die)
        {
            Name = name;
            Country = country;
            Birth = birth;
            Die = die;
        }

        public int CompareTo(object obj)
        {
            Artists a = (Artists)obj;
            return this.Birth.CompareTo(a.Birth);
        }

        public override string ToString()
        {
            return string.Format(" {0}, {1}, {2}, {3}", Name, Country, Birth, Die);
        }
    }
}

