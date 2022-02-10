using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LINQ에서 Group by는 특정 조건으로 데이터를 분류하는 기능입니다. 예를 들어 학생들의 평균 점수가 80점 이상인 그룹과 80점 미만인

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

