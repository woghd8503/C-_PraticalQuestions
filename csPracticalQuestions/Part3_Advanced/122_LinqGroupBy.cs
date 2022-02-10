using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ에서 Group by는 특정 조건으로 데이터를 분류하는 기능입니다. 예를 들어 학생들의 평균 점수가 80점 이상인 그룹과 80점 미만인 그룹으로
// 각각의 평균, 최대, 최소값 등을 구할 수 있습니다. Group by 문은 다음과 같이 사용됩니다.

// group a by into g

// a는 from 문에서 사용한 변수이고, b는 분류 기준이며, c는 그룹 변수입니다. 즉, a에서 b분류 기준으로 그룹을 나눈 것이 g가 됩니다.
// 다음의 프로그램은 앞장에서 사용한 이름, 학번, 성적이 포함된 Student 클래스를 사용하여 평균 점수가 80점 이상인 학생들과 80점 미만인
// 학생들로 나누고 각 그룹별로 학생 수, 평균 점수, 최고 점수를 출력합니다.

namespace ConsoleApp1
{
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> Scores { get; set; }
    }

    class Program
    {
        static List<Student> students;

        static void Main(string[] args)
        {
            students = new List<Student>
            {
                new Student { Name="PjKim", Id=19001001, Scores = new List<int>{86,90,76}},
                new Student { Name="BsKim", Id=19001002, Scores = new List<int>{56,92,93}},
                new Student { Name="YsCho", Id=19001003, Scores = new List<int>{69,85,75}},
                new Student { Name="BiKang", Id=19901004, Scores = new List<int>{88,80,57}}
            };

            var result = from student in students
                        group student by student.Scores.Average() >= 80 into g
                        select new
                        {
                            key = g.Key == true ? "80점 이상" : "80점 미만",
                            count = g.Count(),
                            avr = g.Average(Student => Student.Scores.Average()),
                            max = g.Max(Student => Student.Scores.Average())
                        };
            foreach (var item in result)
            {
                Console.WriteLine("{0} : 학생 수 = {1}", item.key, item.count);
                Console.WriteLine("{0} : 평균 점수 = {1:F2}", item.key, item.avr);
                Console.WriteLine("{0} : 최고 점수 = {1:F2}", item.key, item.max);
                Console.WriteLine();
            }
        }
    }
}

