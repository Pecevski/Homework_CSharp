using Lottary.Entities;
using Lottary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lottary.Helpers
{
    public class WinningPrises
    {
        public static void MatchPrises(Session session)
        {
            foreach (var ticket in Session.Tickets)
            {
               
            var matches = LottaryHelpers.CheckTicket(session.WinningCombination, ticket.Combination);

                switch (matches)
                {
                    case 4:
                        ticket.Prize = Prize.TV;
                        Console.WriteLine($"The user {ticket.User.FullName}  won {ticket.Prize}");
                        break;
                    case 5:
                        ticket.Prize = Prize.Vacation;
                        Console.WriteLine($"The user {ticket.User.FullName}  won {ticket.Prize}");
                        break;
                    case 6:
                        ticket.Prize = Prize.MotorBike;
                        Console.WriteLine($"The user {ticket.User.FullName}  won {ticket.Prize}");
                        break;
                    case 7:
                        ticket.Prize = Prize.Car;
                        Console.WriteLine($"The user {ticket.User.FullName}  won {ticket.Prize}");
                        break;
                    default:
                        Console.WriteLine("Ticket is without win!");
                        break;
                }
                
                if (matches < 4)
                {
                    Array.Resize(ref Session.TicketsWithoutAPrice, Session.TicketsWithoutAPrice.Length + 1);
                    Session.TicketsWithoutAPrice[^1] = ticket;
                }
            }
        }
    }
}
