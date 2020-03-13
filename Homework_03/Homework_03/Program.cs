using System;

namespace Homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EXERCISE 01:
            //Get an input number from the console
            //Print all numbers from 1 to that number
            Console.WriteLine("Input number:");
           
            int number;
            bool parseNum = int.TryParse(Console.ReadLine(), out number);

            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //Get another input number from the console
            //Print all numbers from that number to 1
            Console.WriteLine("Input another number:");
            
            int inputNum;
            bool parseNumber = int.TryParse(Console.ReadLine(), out inputNum);
            int n = 1;
            while (n <= inputNum)
            {
                Console.WriteLine(inputNum--);
            }
            Console.ReadLine();

            #endregion

            #region EXERCISE 02:
            Console.WriteLine("Input Number:");

            bool parseEven = int.TryParse(Console.ReadLine(), out int evenNum);
            for (int i = 2; i <= evenNum; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            Console.WriteLine("Input Number:");

            bool parseOdd = int.TryParse(Console.ReadLine(), out int evenOdd);
            for (int i = 1; i <= evenOdd; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            #endregion

            #region EXERCISE 03:
            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N
            //Print all the names after user enters N
            //Hint: we need to use endless loop until user enter N, then we want to "break" the loop

            var index = 0;
            string[] namesArray = new string[100];
            Console.WriteLine("Enter a name:");
            while (true)
            {
                string input = Console.ReadLine();
               
                if (input.Length > 1)
                {
                    namesArray[index] = input;
                    index++;
                }
                Console.WriteLine("Do you want to enter another name? Y/N");
                if(input.ToUpper() == "N")
                {
                    Console.WriteLine("Names in namesArray are:");
                    foreach (var name in namesArray)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                }
            }
            Console.ReadLine();

            //string[] names = new string[10];
            //var index = 0;
            //Console.WriteLine("Please enter a name:");
            //while (true)
            //{
            //    string userName = Console.ReadLine();
            //    if (userName.Length > 1)
            //    {
            //        names[index] = userName;
            //        index++;
            //    }
            //    Console.WriteLine("Would you like to enter another name? Y/N?");
            //    if (userName.ToLower() == "n")
            //    {

            //        Console.WriteLine("\nThe entered names are: ");
            //        foreach (var name in names)
            //        {
            //            Console.Write(name + " ");
            //        }
            //        break;
            //    }
            //}
            //Console.ReadLine();

           #endregion
        }
    }
}
