using System;

namespace DogExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Dog dog1 = new Dog()
            {
                Id = 1,
                Name = "Johny",
                Color = "Black"
            };
            dog1.Bark();
            Console.ResetColor();
            Dog dog2 = new Dog()
            {
                Id = 2,
                Name = "Joy",
                Color = "Brown"
            };
            dog2.Bark();
            Console.ForegroundColor = ConsoleColor.Green;
            Dog dog3 = new Dog()
            {
                Id = 0,
                Name = "Jacky",
                Color = "White"
            };
            dog3.Bark();
            Console.ResetColor();
            Console.WriteLine("-------------------------");
            Shelter.Dogs.Add(dog1);
            Shelter.Dogs.Add(dog2);
            Shelter.Dogs.Add(dog3);

            Shelter.PrintAll();
            Console.ReadLine();
            
        }
    }
}
