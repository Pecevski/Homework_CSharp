using System;
using System.IO;
namespace Tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   Tablica");
            Console.WriteLine("----------------------");

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    int product = i * j;
                    Console.WriteLine($"{i} * {j} =  {product}");
                }
                Console.WriteLine("----------------------");
            }

            string fileCreate = @".\file.txt";
            if (!File.Exists(fileCreate))
            {
                File.Create(fileCreate).Close();
            }

            using(StreamWriter sw = File.AppendText(fileCreate))
            {

                for (int i = 1; i < 11; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        int product = i * j;
                        sw.WriteLine($"{i} * {j} =  {product}");
                    }
                }

            }

            Console.ReadLine();
        }
    }
}
