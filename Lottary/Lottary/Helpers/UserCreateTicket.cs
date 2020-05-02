using Lottary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lottary.Helpers
{
    public class UserCreateTicket
    {
        public static void CreateTicket()
        {

            Console.Write("Input fullname: ");
            var fullName = Console.ReadLine();
            var ticket = new Ticket();
            var user = new User(fullName);
            ticket.User = user;
            

            Console.WriteLine("Input the age: ");
           
            var inputAge = int.TryParse(Console.ReadLine(), out int age);

            while (true)
            {
                if (age > 17)
                {
                    ticket.User.SetAge(age);
                    break;
                }
                Console.WriteLine("Please enter a valid age!");
                inputAge = int.TryParse(Console.ReadLine(), out _);
                break;
            };
            

            Console.WriteLine("Input your combination of 7 numbers from 1 to 36");

            for (int i = 0; i < ticket.Combination.Length; i++)
            {
                var inputNumbers = int.TryParse(Console.ReadLine(), out int number);

                if (number > 0 && number < 37)
                {
                    if (Array.IndexOf(ticket.Combination, number) != -1)
                    {
                        while (Array.IndexOf(ticket.Combination, number) != -1)
                        {
                            Console.WriteLine("You entered the same number twice, please enter another number!");
                            inputNumbers = int.TryParse(Console.ReadLine(), out number);

                        }
                    }
                    ticket.Combination[i] = number;
                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number!");
                    Console.ReadLine();
                }
            }
            
            Session.ArrayOfTickets(ticket);
            user.BuyTicket(fullName);
        }

    }
}
