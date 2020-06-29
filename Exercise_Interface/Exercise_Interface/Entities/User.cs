using Exercise_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Interface.Entities
{
    public abstract class User : IUser
    {
        public int ID { get ; set ; }
        public string Name { get ; set ; }
        public string Username { get; set ; }
        public string Password { get; set ; }

        public virtual void PrintUser()
        {
            Console.WriteLine($"Id: {ID}, Name: {Name}, Username: {Username}");
        }
    }
}
