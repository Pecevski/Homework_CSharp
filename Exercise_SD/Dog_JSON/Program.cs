using System;
using System.IO;
using Newtonsoft.Json;

namespace Dog_JSON
{
    class Program
    {
        public static string textFile = @"C:\Users\Dell\source\repos\Exercise_SD\Dog_JSON\bin\Debug\netcoreapp3.1\file.txt";
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input dog name: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("Input dogs age: ");
            int dogAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Input dogs color : ");
            string dogColor = Console.ReadLine();

            Dog rex = new Dog(dogName, dogAge, dogColor);

            string fileDog = @".\file.txt";
            if (!File.Exists(fileDog))
            {
                File.Create(fileDog).Close();
            };

            string dogJson = JsonConvert.SerializeObject(rex);
            using (StreamWriter sw = new StreamWriter(fileDog, true))
            {
                sw.WriteLine(dogJson);
                //Console.WriteLine(dogJson);
            };

            Console.WriteLine("--------------------------------");
            if (File.Exists(textFile))
            {
                string readFile = File.ReadAllText(textFile);
                Console.WriteLine(readFile);
            }

            Console.ReadLine();
        }
    }
}
