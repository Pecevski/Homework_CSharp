using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Generics.Entities
{
    public class Dog : Pet
    {
        public Dog(int age, string name, string type, bool goodBoy, string favoriteFood) : base (name, age, type)
        {
            Age = age;
            Name = name;
            Type = type;
            GoodBoy = goodBoy;
            FavoriteFood = favoriteFood;
        }
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public override string PrintInfo()
        {
            return $"List of Dogs: {Type} - {Name} eats {FavoriteFood}!";
        }
    }
}
