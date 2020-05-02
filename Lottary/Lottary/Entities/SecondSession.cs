using Lottary.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lottary.Entities
{
    public class SecondSession : Session 
    {
        public static Ticket luckyLoserSession { get; set; }
        public static void GetRandomTicketWithTwoMatches(SecondSession secondSession)
        {
            
            foreach (var ticket in Tickets)
            {
                var matches = LottaryHelpers.CheckTicket(secondSession.WinningCombination, ticket.Combination);

                if (matches == 2)
                {
                    Array.Resize(ref TicketsWithTwoMatchings, TicketsWithTwoMatchings.Length + 1);
                    TicketsWithTwoMatchings[^1] = ticket;

                    if (TicketsWithTwoMatchings.Length != 0)
                    {
                        var luckyLoserIndex = new Random().Next(0, TicketsWithTwoMatchings.Length - 1);
                        luckyLoserSession = TicketsWithTwoMatchings[luckyLoserIndex];
                        Console.WriteLine($"The lucky loser in second session  is: {luckyLoserSession.User.FullName} and won a Vacation!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("There are no players with two matchings!");
                    break;
                }
            }
        }
    }
}

