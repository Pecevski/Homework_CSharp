using QuizApp.Entities;
using QuizApp.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Quiz app
           
            bool exit = false;
            bool finished = false;

            //LOG IN
            while (finished == false && exit == false)
            {
                Console.WriteLine($"Welcome to Quiz! Are you a teacher or a student or exit if you enter quiz accidental? \n Student  - 1 \n Teacher - 2  \n Exit - 3");
                var choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        StudentHelper.StudentLogsIn();

                        break;
                        
                    case "2":
                        TeacherHelper.TeacherLogsIn();
                        
                        break;
                    case "3":
                        Console.WriteLine("You exit quiz!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again!");
                        break;
                }
                
            }
           
            Console.ReadLine();
        }
    }
}
