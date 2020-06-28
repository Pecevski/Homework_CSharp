using DocumentFormat.OpenXml.Wordprocessing;
using Exercise.Generics.Entities;
using System;

namespace Exercise.Generics
{
    class Program
    {
        //public static PetStore<Cat> CatStore = new PetStore<Cat>();
        //public static PetStore<Dog> DogStore = new PetStore<Dog>();
        //public static PetStore<Fish> FishStore = new PetStore<Fish>();

        static void Main(string[] args)
        {
            PetStore<Cat> CatStore = new PetStore<Cat>();
            PetStore<Dog> DogStore = new PetStore<Dog>();
            PetStore<Fish> FishStore = new PetStore<Fish>();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Cat bella = new Cat("Bella", 3, "Angorian", true, 7);
            CatStore.Pets.Insert(0, bella);
       
            var maza = new Cat("Maza", 8, "Siamian", false, 1);
            CatStore.Pets.Add(maza);
            CatStore.BuyPet("Bella");
            CatStore.PrintsPets();
            
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            var rex = new Dog(11, "Rex", "German Shepard", true, "meat");
            DogStore.Pets.Insert(0, rex);
            DogStore.Pets.Add(new Dog(2, "Jacky","Pitbul", true, "bones"));
            DogStore.Pets.Add(new Dog(5, "Johny", "Terier", false, "bread"));
            DogStore.BuyPet("Johny");
            DogStore.PrintsPets();
            
            Console.WriteLine("--------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Blue;
            FishStore.Pets.Add (new Fish("small", "yellow", 1, "Goldfish", "Goldy"));
            FishStore.Pets.Add(new Fish("big", "black", 2, "Karas", "Blacky"));
            FishStore.PrintsPets();


            Console.ReadLine();
        }
    }
}
