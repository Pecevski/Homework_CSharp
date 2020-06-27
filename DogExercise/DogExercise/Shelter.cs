using System;
using System.Collections.Generic;
using System.Text;

namespace DogExercise
{
    public static class Shelter
    {
        public static List<Dog> Dogs = new List<Dog>();

        public static void PrintAll()
        {
            foreach (var dog in Dogs)
            {
                Console.WriteLine($"{dog.Name} - {dog.Color}");
            }
        }
    }
}
