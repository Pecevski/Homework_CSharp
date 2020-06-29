using Exercise_Interface.Entities;
using System;
using System.Collections.Generic;

namespace Exercise_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student miki = new Student()
            {
                ID = 1,
                Name = "Milan",
                Grades = new List<int>() { 3, 3, 4, 4, 5 }
            };
            Student jovan = new Student()
            {
                ID = 2,
                Name = "Jovan",
                Grades = new List<int>() { 5, 5, 4, 5, 5 }
            };
            Teacher goce = new Teacher()
            {
                ID = 3,
                Name = "Goce",
                Subjects = { "C#", "MVC", "WebAPI" }
            };
            Teacher ivan = new Teacher()
            {
                ID = 4,
                Name = "Ivan",
                Subjects = { "HTML", "CSS" }
            };

            miki.PrintUser();
            Console.WriteLine("--------------------------------------");
            jovan.PrintUser();
            Console.WriteLine("--------------------------------------");
            goce.PrintUser();
            Console.WriteLine("--------------------------------------");
            ivan.PrintUser();
            Console.ReadLine();
        }
    }
}
