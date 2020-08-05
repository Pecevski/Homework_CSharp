using QuizApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Helpers
{
    public class DataBase
    {
        public static List<Student> AllStudent()
        {
            return new List<Student>()
            {
                new Student()
                {
                    FullName = "Drazen Petrovic",
                    Username = "drazen@gmail.com",
                    Password = "0706"
                },
                new Student()
                {
                    FullName = "Arijan Komazec",
                    Username = "arijan@gmail.com",
                    Password = "1234",
                },
                new Student()
                {
                    FullName = "Stojko Vrankovic",
                    Username = "stojko@gmail.com",
                    Password = "5555",
                },
                 new Student()
                {
                    FullName = "Toni Kukoc",
                    Username = "toni@gmail.com",
                    Password = "7777",
                 },
                  new Student()
                  {
                    FullName = "Dino Ragja",
                    Username = "dino@gmail.com",
                    Password = "1414",
                  },

            };
        }

        public static List<Teacher> AllTeachers()
        {
            return new List<Teacher>()
            {
                new Teacher()
                {
                    FullName = "Goce Kabov",
                    Username = "goce@gmail.com",
                    Password = "0208",
                },
                new Teacher()
                {
                    FullName = "Miodrag Cecikj",
                    Username = "miodrag@gmail.com",
                    Password = "1505",
                },
                new Teacher()
                {
                    FullName = "Ivan Trajchev",
                    Username = "ivan@gmail.com",
                    Password = "2222",
                },
            };
        }
    }
}
