using Homework_Class08.ENUM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class08.Entities
{
    public class Car
    {
        
        public Car()
        {

        }

        public string Brand;
        public string Model;
        public int Doors;
        public int TopSpeed;
        public int ID;

        public Consumption Consumption;
        public EngineType Engine;

        public void PrintInfo()
        {
            Console.WriteLine($"The car is {Brand} , model {Model} and has {Doors} doors, and max speed is {TopSpeed} km with ID {ID}.");
        }

        public int Drive(int distance)
        {
            var drive = distance * (int)Consumption / 10;

            return drive;
        }
    }
}
