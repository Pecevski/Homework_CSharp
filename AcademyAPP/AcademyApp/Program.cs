using AcademyApp.Entities;
using AcademyApp.Enums;
using AcademyApp.Helpers;
using SubjectServices;
using System;
using System.Collections.Generic;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var participant1 = new Participant();
            participant1.FirstName = "Miodrag";
            participant1.LastName = "Cekikj";
            participant1.DateOfBirth = new DateTime(1989, 5, 15);
            participant1.Role = AcademyRole.Trainer;

            // List of Subjects instead of array----Also in class Participant initiated public List Subject
            participant1.Subjects = new List<Subject>()
            {
                new Subject()
                {
                    Title = "C# Basic",
                    Semester = 2,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio",
                        AlternativeIDE = "Visual Studio Code"
                    }
                },
                new Subject()
                {
                    Title = "C# Advanced",
                    Semester = 2,
                    Tools = new Tooling()
                    {
                        MainIDE = "Visual Studio",
                        AlternativeIDE = "Visual Studio Code"
                    }
                }
            };

            participant1.Greetings();

            Console.WriteLine("-----------------------------------------------");
            var participant2 = new Participant();
            participant2.FirstName = "Goce";
            participant2.LastName = "Kabov";
            participant2.DateOfBirth = new DateTime(1992, 5, 15);
            participant2.Role = AcademyRole.Assistant;
            participant2.Greetings();

            Console.WriteLine("-----------------------------------------------");
            var participant3 = new Participant("Bob", "Marley");
            participant3.Role = AcademyRole.Assistant;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            participant3.PrintFullName();


            Console.WriteLine("-----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            var participant4 = new Participant()
            {
                FirstName = "Tupac",
                LastName = "Shakur"
            };

            var cSharpBasic = new Subject();
            cSharpBasic.Title = "C# Basic";
            cSharpBasic.Semester = 2;

            var cSharpAdvanced = new Subject();
            cSharpAdvanced.Title = "C# Advanced";
            cSharpAdvanced.Semester = 2;

            //List of Subject for participant4

            participant4.Subjects = new List<Subject>();
            participant4.Subjects.Add(cSharpBasic);
            participant4.Subjects.Add(cSharpAdvanced);

            foreach (var subject in participant4.Subjects)
            {
                Console.WriteLine(subject.Title);
            }

            participant4.PrintFullName();

            Console.WriteLine("-----------------------------------------------");

            // List of Participants and setting a specific Index 
            List<Participant> participants = new List<Participant>();
            participants.Insert(0, participant1);
            participants.Insert(1, participant2);
            participants.Insert(2, participant3);
            participants.Insert(3, participant4);
           
            // Corection of the first parameter and appropriatelly in to ParticipantHelper method in Helpers Folder
            ParticipantHelper.FindParticipantByRole( participants, AcademyRole.Trainer);

            Console.ReadLine();
        }
    }
}