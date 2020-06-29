using Exercise_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Interface.Entities
{
    public class Student : User, IStudent
    {
        public Student()
        {

        }
        public List<int> Grades { get; set; }

        public override void PrintUser()
        {
            foreach (var grade in Grades)
            {
                Console.WriteLine($"Student {Name} is having Grades: {grade}");
            }
            
        }
    }
}
