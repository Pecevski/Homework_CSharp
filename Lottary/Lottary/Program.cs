using Lottary.Entities;
using Lottary.Enum;
using Lottary.Helpers;
using System;

namespace Lottary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create structure
            // Create Models

            User user1 = new User()
            {
                FullName = "Igor Dzambazov"
            };

            user1.SetAge(55);
            user1.BuyTicket(user1.FullName);

            Ticket ticket1 = new Ticket()
            {
                Combination = new int[] { 9, 24, 4, 14, 1, 27, 3 },
                User = user1
            };
            Session.ArrayOfTickets(ticket1);

            User user2 = new User()
            {
                FullName = "Ilija Pecevski"
            };

            user2.SetAge(41);
            user2.BuyTicket(user2.FullName);

            Ticket ticket2 = new Ticket()
            {
                Combination = new int[] { 10, 25, 5, 15, 2, 28, 6 },
                User = user2
            };
            Session.ArrayOfTickets(ticket2);

            User user3 = new User()
            {
                FullName = "Mirko Mitrevski"
            };

            user3.SetAge(65);
            user3.BuyTicket(user3.FullName);

            Ticket ticket3 = new Ticket()
            {
                Combination = new int[] { 1, 12, 35, 18, 20, 29, 16 },
                User = user3
            };
            Session.ArrayOfTickets(ticket3);

            User user4 = new User()
            {
                FullName = "Igi Pop"
            };

            user4.SetAge(25);
            user4.BuyTicket(user4.FullName);

            Ticket ticket4 = new Ticket()
            {
                Combination = new int[] { 11, 22, 33, 36, 21, 23, 7 },
                User = user4
            };

            Session.ArrayOfTickets(ticket4);

            User user5 = new User()
            {
                FullName = "Anastasija Pecevska"
            };

            user5.SetAge(18);
            user5.BuyTicket(user5.FullName);

            Ticket ticket5 = new Ticket()
            {
                Combination = new int[] { 4, 18, 15, 5, 20, 8, 10 },
                User = user5
            };

            Session.ArrayOfTickets(ticket5);

            //First Session
            Console.WriteLine("-------------------------------------------------");
            FirstSession firstSession = new FirstSession();
            UserCreateTicket.CreateTicket();           
            firstSession.StartSession();
            
            WinningPrises.MatchPrises(firstSession);
            
            FirstSession.GetRandomTicket(firstSession);

            //Second Session
            Console.WriteLine("-------------------------------------------------");
            SecondSession secondSession = new SecondSession();
            secondSession.StartSession();
           
            WinningPrises.MatchPrises(secondSession);
            
            SecondSession.GetRandomTicketWithTwoMatches(secondSession);
           
            Console.ReadLine();
        }
    }
}
