using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor  = ConsoleColor.Red;
            Console.WriteLine("STOP");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("READY");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("GO");
            Console.ReadLine();
        }
    }
}
