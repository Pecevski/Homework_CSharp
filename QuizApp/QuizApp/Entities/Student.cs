using QuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using QuizApp.Helpers;
using QuizApp.Entities;
using System.Linq;

namespace QuizApp.Entities
{
    public class Student : User
    {
        public bool Logged = false;

        public UserTypes Role;
        public int Grade { get; set; }

        public static List<string> loggedStudentsList = new List<string>();
        public static List<int> gradesStudentsList = new List<int>();
        public void DoneTest(string username, bool log, int grade)
        {
            log = true;
            loggedStudentsList.Add(username);
            gradesStudentsList.Add(grade);
        }

    }
}