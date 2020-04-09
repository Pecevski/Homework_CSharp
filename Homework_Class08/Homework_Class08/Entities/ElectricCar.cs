using Homework_Class08.ENUM;
using System;

namespace Homework_Class08.Entities
{
    public class ElectricCar : Car
    {
       public int BatteryCapacity = 100;
       public double BatteryUsage;

        public void Recharge(int minutes)
        {
           
            var recharge = minutes / 10;
            if (minutes == 100 * 10)
            {
                Console.WriteLine($"Can't charge longer that {minutes} minutes");
            } 
            else
            {
                BatteryCapacity += recharge;
                Console.WriteLine($"The Battery has been charged for {recharge}%!");
            }

        }
    }
}
