using Lottary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lottary.Entities
{
    public class Ticket
    {
        public Ticket()
        {
            Combination = new int[7];
        }
        public int[] Combination { get; set; }
        public User User { get; set; }

        public Prize Prize { get; set; }
    }
}
