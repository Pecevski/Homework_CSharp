using LottoServices;
using System;
using System.Collections.Generic;
using System.Text;
using Lottary.Enum;
using Lottary.Helpers;

namespace Lottary.Entities
{
    public class Session
    {
        static int counter = 0;
        public Session()
        {
            counter += 1;
            SessionId = counter;
            WinningCombination = new int[7];
        }

        private int SessionId { get; set; }
        public int[] WinningCombination { get; set; }

        public static Ticket[] Tickets = new Ticket[0];

        public static void ArrayOfTickets(Ticket ticket)
        {
            Array.Resize(ref Tickets, Tickets.Length + 1);
            Tickets[^1] = ticket;
        }

        public void StartSession()
        {
            WinningCombination = LottoNumberGenerator.GenerateNumbers();

            Console.WriteLine($"The winning combination is:");
            foreach (var num in WinningCombination)
            {
                Console.WriteLine($"{num}");
            }
        }


        public static Ticket[] TicketsWithoutAPrice = new Ticket[0]; 

        public static Ticket[] TicketsWithTwoMatchings = new Ticket[0];

    }
}
