using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                new Student { Name="Pjkim", Id=19001001, Scores = new List<int>{86,90,76}},
                new Student { Name="BsKim", Id=}
            }
        }
    }
}

