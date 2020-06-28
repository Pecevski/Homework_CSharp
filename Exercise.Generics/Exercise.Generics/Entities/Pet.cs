using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Generics.Entities
{
    public abstract class Pet
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public abstract string PrintInfo();
        public Pet(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }
    }
}
