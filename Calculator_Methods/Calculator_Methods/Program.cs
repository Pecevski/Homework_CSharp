using System;

namespace Calculator_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] operators = new char[] { '+', '-', '*', '/', 's', 'S' };
            char answerChar;

            while (true)
            {

                string numInputOne;
                string numInputTwo;

                while (true)
                {
                    Console.WriteLine("Input type of operation:");

                    Console.WriteLine(" + ");
                    Console.WriteLine(" - ");
                    Console.WriteLine(" * ");
                    Console.WriteLine(" / ");
                    Console.WriteLine(" S ");

                    bool answer = char.TryParse(Console.ReadLine(), out answerChar);
                    if (answer && Array.IndexOf(operators, answerChar) != -1) break;
                    Console.WriteLine("Invalid operator");
                }

                if (answerChar == 's' || answerChar == 'S')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have not used calculator! The aplication will automatically close.");
                    Console.ReadLine();
                    break;
                }

                int numOne;
                while (true)
                {
                    Console.WriteLine("Enter first number:");
                    numInputOne = Console.ReadLine();
                    bool parsed = int.TryParse(numInputOne, out numOne);
                    if (parsed) break;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input number");
                }

                int numTwo;
                while (true)
                {
                    Console.WriteLine("Enter second number:");
                    numInputTwo = Console.ReadLine();
                    bool parsed = int.TryParse(numInputTwo, out numTwo);
                    if (parsed) break;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input number.");
                }

                switch (answerChar)
                {
                    case '+':
                        int suming = Sum(numOne, numTwo);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result: " + suming);
                        break;
                    case '-':
                        int minus = Substract(numOne, numTwo);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result: " + minus);
                        break;
                    case '*':
                        int product = Multiply(numOne, numTwo);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result:" + product);
                        break;
                    case '/':
                        int result = Divide(numOne, numTwo);
                        if (numOne == 0 || numTwo == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Division with zero is not possible!");
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result: " + result);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid operation selected! The aplication will automatically close.");
                        break;
                }

                char close;
                bool exit = char.TryParse(Console.ReadLine(), out close);
                if (Char.ToLower(close) == 's')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thank you for using calculator! The aplication will automatically close.");
                    return;
                }

                Console.ReadLine();
            }
        }
    
        public static int Sum(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Substract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
    }
}
