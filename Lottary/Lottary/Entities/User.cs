using System;
using System.Collections.Generic;
using System.Text;

namespace Lottary.Entities
{
    public class User
    {
        public User()
        {

        }

        public string FullName { get; set; }
        public int Age { get; set; }


        public void BuyTicket(string fullName)
        {
            FullName = fullName;
            Console.WriteLine($"{fullName} got a Ticket");
        }

        public void SetAge(int age)
        {
            if (age < 18)
                Console.WriteLine("Not allowed for users uneder age of 18.");
            else Age = age;
        }
    }
}
