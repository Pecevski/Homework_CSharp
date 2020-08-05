using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuizApp.Entities;
using QuizApp.Helpers;

namespace QuizApp.Helpers
{
    public class TeacherHelper
    {
        public static void TeacherLogsIn()
        {
            var studentList = DataBase.AllStudent();
            var teacherList = DataBase.AllTeachers();

            Console.WriteLine("Please enter the userrname for teachers:");
            var username = Console.ReadLine();
            Console.WriteLine("Please enter the password for teachers:");
            var password = Console.ReadLine();
            Teacher listTeacher = teacherList.SingleOrDefault(t => t.Username == username && t.Password == password);

            if (listTeacher != null)
            {

                //TEACHER LOGS IN
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Welcome teacher {listTeacher.FullName}!");
                Console.ResetColor();
                Console.WriteLine("List of Students: ");

                //var teacher = new Teacher();
                //teacher.ListOfStudents();
                foreach (var student in studentList)
                {
                    student.Grade = QuestionsDataBase.GetGrade();
                    if (Student.loggedStudentsList.Contains(student.Username))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Student {student.FullName}, with grade of {student.Grade}");
                        Console.ResetColor();
                    }
                    else if (!(Student.loggedStudentsList.Contains(student.Username)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(student.FullName);
                        Console.ResetColor();
                    }
                }


            }
            else if (listTeacher == null)
            {
                Console.WriteLine("Incorrect username or password, please try again.");
            }
        }
    }
}
