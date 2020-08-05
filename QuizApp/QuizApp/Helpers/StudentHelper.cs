using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuizApp.Entities;
using QuizApp.Helpers;

namespace QuizApp.Helpers
{
    public class StudentHelper
    {
        public static void StudentLogsIn()
        {
            var studentList = DataBase.AllStudent();
            var teacherList = DataBase.AllTeachers();

            Console.WriteLine("Please enter the username for students:");
            var usernameS = Console.ReadLine();
            Console.WriteLine("Please enter the password for students:");
            var passwordS = Console.ReadLine();

            Student listStudent = studentList.SingleOrDefault(s => s.Username == usernameS && s.Password == passwordS);

            if (listStudent != null)
            {
                if (!Student.loggedStudentsList.Contains(listStudent.Username))
                {
                    //STUDENT LOGS IN

                    QuestionsDataBase.DisplayAndCheckQuestions();
                    listStudent.Grade = QuestionsDataBase.GetGrade();
                    
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{listStudent.FullName}, your final grade is:{listStudent.Grade}");
                    Console.ResetColor();
    
                    listStudent.DoneTest(listStudent.Username, listStudent.Logged, listStudent.Grade); 

                }
                else if (Student.loggedStudentsList.Contains(listStudent.Username))
                {
                    Console.WriteLine("Sorry, but you already did the quiz!");

                }
            }
            else if (listStudent == null)
            {
                Console.WriteLine("No such Student.Try again.");
            };
        }
    }
}
