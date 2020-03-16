using System;

namespace RealCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input type of arithmetic operation:");
             
            Console.WriteLine(" + ");
            Console.WriteLine(" - ");
            Console.WriteLine(" * ");
            Console.WriteLine(" / ");
            Console.WriteLine(" S ");

            if (Console.ReadLine() == "s" || Console.ReadLine() == "S")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have not used calculator! The aplication will automatically close.");
                return;
            }

            while (true)
            {
                Console.WriteLine("Your option: ");
                string operators = Console.ReadLine();
                
                string numInputOne;
                string numInputTwo;

                Console.WriteLine("Enter first number:");
                numInputOne = Console.ReadLine();
                int numOne;
                while (!int.TryParse(numInputOne, out numOne))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input number. The aplication will automatically close. ");                    
                    return;
                }
                
                Console.WriteLine("Enter second number:");
                numInputTwo = Console.ReadLine();
                int numTwo;
                while (!int.TryParse(numInputTwo, out numTwo))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input number. The aplication will automatically close. ");                  
                    return;
                }

                switch (operators)
                {
                    case "+":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result: {numOne} + {numTwo} = " + (numOne + numTwo));
                        break;
                    case "-":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result:  {numOne} - {numTwo} = " + (numOne - numTwo));
                        break;
                    case "*":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result: {numOne} * {numTwo} = " + (numOne * numTwo));
                        break;
                    case "/":
                        if (numOne == 0 || numTwo == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Division with zero is not possible!");
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result: {numOne} / {numTwo} = " + (numOne / numTwo));
                        break;
                    default:                        
                         Console.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("Invalid operation selected! The aplication will automatically close.");
                         break;
                }

                if (Console.ReadLine() == "s" || Console.ReadLine() == "S")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thank you for using calculator! The aplication will automatically close.");
                    return;
                }
                
            }
        }
    }
}
