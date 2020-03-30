using System;

namespace Homework_Classes
{
    #region Task 07 - Class Dog
    public class Dog
    {
        public string Name;
        public string Rase;
        public string Color;
        
        // Methods
        public void Eat()
        {
            Console.WriteLine("The dog is now eating.");
        }

        public void Play()
        {
            Console.WriteLine("The dog is now playing.");
        }

        public void ChaseTail()
        {
            Console.WriteLine("Dog is now chasing its tail.");
        }


    }

    #endregion

    #region Task 08 - Class Human

    public class Human
    {
        public string FirstName;
        public string LastName;
        public string Age;
        
        //Method
        public void GetPersonStats()
        {
            Console.WriteLine($"Human's fullname is {FirstName} {LastName} and is {Age} years old!");
        }
    }

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 07 - Object Dog

            Dog wolf = new Dog();

            Console.WriteLine("Input dogs name: ");
            wolf.Name = Console.ReadLine();

            Console.WriteLine("Input dogs rase: ");
            wolf.Rase = Console.ReadLine();

            Console.WriteLine("Input dogs color: ");
            wolf.Color = Console.ReadLine();

            Console.WriteLine("Choose the action of your dog: ");
            Console.WriteLine("1 - Eat");
            Console.WriteLine("2 - Play");
            Console.WriteLine("3 - ChaseTail");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    wolf.Eat();
                    break;
                case "2":
                    wolf.Play();
                    break;
                case "3":
                    wolf.ChaseTail();
                    break;
                default:
                    Console.WriteLine("You did not choose any action!");
                    break;
            }
            Console.ReadLine();

            #endregion

            #region Task 08 - Object Human

            Human people = new Human();
            Console.WriteLine("Please input the required information!");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Input first name: ");
            people.FirstName = Console.ReadLine();

            Console.WriteLine("Input last name: ");
            people.LastName = Console.ReadLine();

            Console.WriteLine("Input age: ");
            people.Age = Console.ReadLine();

            Console.WriteLine("--------------------------------------");
            people.GetPersonStats();

            Console.ReadLine();
            #endregion

        }
    }
}
