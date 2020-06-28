using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Generics.Entities
{
    public class Cat : Pet
    {

        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, int age, string type, bool lazy, int livesLeft) : base(name, age, type)
        {
            Name = name;
            Age = age;
            Type = type;
            Lazy = lazy;
            LivesLeft = livesLeft;
        }
        
        public override string PrintInfo()
        {
            return $"List of Cats: {Type} - {Name}!";
        }
    }
}
