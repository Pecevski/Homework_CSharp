using Exercise_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Interface.Entities
{
    public class Teacher : User, ITeacher
    {
        public Teacher()
        {

        }
        public List<string> Subjects { get; set; } = new List<string>();
        public override void PrintUser()
        {
            foreach (var subject in Subjects)
            {
                Console.WriteLine($"Taecher {Name} is teaching this Subjects: {subject}");
            }
            
        }
    }
}
