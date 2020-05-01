using System;
using System.Collections.Generic;
using System.Text;

namespace Lottary.Entities
{
    public class FirstSession : Session
    {
        public static Ticket luckyLosers { get; set; }
        public static void GetRandomTicket(FirstSession firstSession)
        {
            
            if (TicketsWithoutAPrice.Length >= 1)
            {
                var luckyLoserIndex = new Random().Next(0, TicketsWithoutAPrice.Length - 1);
                luckyLosers = TicketsWithoutAPrice[luckyLoserIndex];
                Console.WriteLine($"The lucky loser in first session is: {luckyLosers.User.FullName} and won a TV!");
            }

        }
    }
}
