using System;

namespace ENUM_APP
{
    public enum StudentGrades
    {

        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StudentGrades.Ten);

            Console.ReadLine();
        }
    }
}
