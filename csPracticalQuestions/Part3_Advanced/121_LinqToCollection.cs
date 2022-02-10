using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// LINQ 쿼리식의 결과에서 새로운 객체를 만들어 컬렉션으로 저장할 수 있습니다.다음의 프로그램은 이름, 학번, 성적이 포함된
// Student 클래스를 사용하여 시험 점수와 평균, 그리고 각 시험에서 커트라인 이상의 점수를 받은 학생들을 출력합니다.
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

            Print(students);
            HighScore(0, 85); // 첫 번째 시험에서 85점 이상인 학생 출력
            HighScore(1, 90); // 두 번째 시험에서 90점 이상인 학생 출력
        }

        private static void HighScore(int exam, int cut)
        {
            var highScore = from student in students
                            where student.Scores[exam] >= cut
                            select new { Name = student.Name, Score = student.Scores[exam] };

            Console.WriteLine($"{exam + 1}번째 시험에서 {cut} 이상의 점수를 받은 학생");
            foreach (var item in highScore)
                Console.WriteLine($"\t{item.Name, -10}{item.Score}");
        }

        private static void Print(List<Student> students)
        {
            foreach (var item in students)
            {
                Console.Write($"{item.Id,-10}{item.Name,-10}");
                foreach (var score in item.Scores)
                    Console.Write($"{score,-5}");
                Console.WriteLine(item.Scores.Average().ToString("F2"));
            }
        }
    }
}

