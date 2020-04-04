using System;
using System.Collections.Generic;
using System.Text;

namespace CodeOrginizer.Entities
{
    public class Address
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public void PrintAdress()
        {
            Console.WriteLine($"Address Name: {Name}");
            Console.WriteLine($"Address Number: {Number}");
        }
    }
}
