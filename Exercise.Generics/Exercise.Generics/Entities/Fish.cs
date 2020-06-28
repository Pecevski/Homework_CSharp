using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Generics.Entities
{
    public class Fish : Pet
    {
        public Fish(string size, string color, int age, string type, string name) : base(name, age, type)
        {
            Size = size;
            Color = color;
            Age = age;
            Type = type;
            Name = name;
        }
        public string Size { get; set; }
        public string Color { get; set; }
        public override string PrintInfo()
        {
            return $"List of Fish: {Type} - {Name}!";
        }
    }
}
