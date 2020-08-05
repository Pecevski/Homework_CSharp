using QuizApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using QuizApp.Enums;

namespace QuizApp.Helpers
{
    public class QuestionsDataBase
    {
        public static List<string> Questions = new List<string> {
            "What is the capital of Tasmania?",
            "What is the tallest building in the Republic of the Congo?",
            "Which of these is not one of Pluto's moons?",
            "What is the smallest lake in the world?",
            "What country has the largest population of alpacas?" 
        };
        public static string AnswerOne { get; set; }
        public static string AnswerTwo { get; set; }
        public static string AnswerThree { get; set; }
        public static string AnswerFour { get; set; }
        public static string AnswerFive { get; set; }

        public static int CorrectAnswers { get; set; }
        public static int DisplayAndCheckQuestions()
        {
            Console.WriteLine("Please choose the correct answer for the following questions and write the letter infront of the answer you think is correct:");
            CorrectAnswers = 0;

            Console.WriteLine($"\n 1.{Questions[0]} \n a) Dodoma \n b) Hobart \n c) Launceston \n d) Wellington");
            AnswerOne = Console.ReadLine();
            if (AnswerOne == "b")
            {
                CorrectAnswers++;
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine($"\n 2.{Questions[1]} \n a) Kinshasa Democratic Republic of the Congo Temple \n b) Palais de la Nation \n c) Kongo Trade Centre \n d) Nabemba Tower");
            AnswerTwo = Console.ReadLine();
            if (AnswerTwo == "d")
            {
                CorrectAnswers++;
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine($"\n 3.{Questions[2]} \n a) Styx \n b) Hydra \n c) Nix \n d) Lugia");
            AnswerThree = Console.ReadLine();
            if (AnswerThree == "c")
            {
                CorrectAnswers++;
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine($"\n 4.{Questions[3]} \n a) Onega Lake \n b) Benxi Lake \n c) Kivu Lake \n d) Wakatipu Lake");
            AnswerFour = Console.ReadLine();
            if (AnswerFour == "b")
            {
                CorrectAnswers++;
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.WriteLine($"\n 5.{Questions[4]} \n a) Chad \n b) Peru \n c) Australia \n d) Niger");
            AnswerFive = Console.ReadLine();
            if (AnswerFive == "b")
            {
                CorrectAnswers++;
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            return CorrectAnswers;
        }

        public static int GetGrade()
        {
            int grade = 0;
            if (CorrectAnswers < 2)
                grade = 1;
            else if (CorrectAnswers == 2)
                grade = 2;
            else if (CorrectAnswers == 3)
                grade = 3;
            else if (CorrectAnswers == 4)
                grade = 4;
            else if (CorrectAnswers == 5)
                grade = 5;
            return grade;
        }


    }
}
