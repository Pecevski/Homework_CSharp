using System;
using System.Collections.Generic;
using System.Text;

namespace CarServices
{
    public class CarID
    {
        public static int GenerateCarID()
        {
            Random rand = new Random();
            return rand.Next(1, 9999999);
        }
    }
}
