using Homework_Class08.ENUM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class08.Entities
{
    public class FuelCar : Car
    {
        public int FuelCapacity;
        public int CurrentFuel;


        public int Refuel(int fuel)
        {

            if(fuel > FuelCapacity)
            {
                Console.WriteLine($"Can't refuel more than {FuelCapacity} litres");
            }
            Console.WriteLine($"Tank has been fueled with {fuel} l.");
            return fuel;

        }
    }
}
