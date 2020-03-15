using System;

namespace Bonus_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 01
            //Write a C# Sharp program to find the sum of first 10 natural numbers
  
            int sum = 0;

            Console.WriteLine("The first 10 natural number are :");
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("The Sum is :" + sum);
            Console.ReadLine();

            #endregion

            #region Exercise 02
            //Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average

            int sumNum = 0;
            int[] num = new int[10];
            Console.WriteLine("Enter 10 numbers for displaying their sum and average:");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                sumNum += num[i];
            }
            Console.WriteLine("The sum of the numbers are:" + sumNum);
            int average;
            average = sumNum / 10;
            Console.WriteLine("The avearge is:" + average);
            Console.ReadLine();

            #endregion

            #region Exercise 03
            //Declare and init array of 10 integers by your choise. 
            //Find maximum and minimum element in that array and their indexes.

            int[] integerArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int min;
            int max;

            min = integerArray[0];
            max = integerArray[0];

            for(int i = 0; i < integerArray.Length; i++)
            {
                if(min > integerArray[i])
                {
                     min = integerArray[i];
                }
                if(max < integerArray[i])
                {
                     max = integerArray[i];
                }
            }
            Console.WriteLine("Minimum element:" + min);
            Console.WriteLine("Minimum element index :" + Array.IndexOf(integerArray, min));
            Console.WriteLine("Maximum element:" + max);
            Console.WriteLine("Maximum element index:" + Array.IndexOf(integerArray, max));

            Console.ReadLine();


            #endregion

            #region Exercise 04
            //Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates
            int[] arrayWithDuplicates = { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };
            int count = 0;

            for (int i = 0; i < arrayWithDuplicates.Length; i++)
            {
                //int count = 0;
                for (int j = i + 1; j < arrayWithDuplicates.Length; j++)
                {

                    if (arrayWithDuplicates[i] == arrayWithDuplicates[j])
                    {
                        count++;
                        break;
                    }                    
                }
            }
            Console.WriteLine("Total number of duplicate elements found in array:" + count);
            Console.ReadLine();

            #endregion

            #region Exercise 05
            //Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays
            int[] oddEvenArray = { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            int[] oddArray = new int[10];
            int[] evenArray = new int [10];
            int m;
            int n = 0;
            int k = 0;

            for(m = 0; m < oddEvenArray.Length; m++)
            {
                if(oddEvenArray[m] % 2 == 0)
                {
                    evenArray[n] = oddEvenArray[m];
                    n++;
                }else
                {
                    oddArray[k] = oddEvenArray[m];
                    k++;
                }
            }

            for(m = 0; m < n; m++)
            {
                Console.WriteLine("EvenArray elements are: " + evenArray[m] );
            }
            Console.WriteLine("------------------------------");

            for (m = 0; m < k; m++)
            {
                Console.WriteLine("OddArray elements are:" + oddArray[m]);
            }

            Console.ReadLine();

            #endregion

            #region Exercise 06
            //Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            //the day with strings. Example: user enters 1, you should print Monday.

            Console.WriteLine("Input a number to get Day displayed:");
            int dayNum = Convert.ToInt32(Console.ReadLine());

            switch (dayNum)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number. Please try again!");
                    break;
            }


            #endregion

            #region Exercise 07
            //Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //Create a logic when user enters specific username to provide a correct password for that user, and when that
            //happens you should print on the screen "You are logged in successfully".
            //If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //repeat the proccess from begining while he / she doesn't input correct username and password.

            string[] userNames = { "user1", "user2", "user3" };
            string[] passwords = { "first", "second", "third" };

            Console.WriteLine("Please enter your username:");
            string userInput = (Console.ReadLine());
            Console.WriteLine("Please enter your password:");
            string passInput = (Console.ReadLine());

            if (userInput == userNames[0] && passInput == passwords[0])
            {
                Console.WriteLine("You are logged in successfully");
            }
            else if (userInput == userNames[1] && passInput == passwords[1])
            {
                Console.WriteLine("You are logged in successfully");
            }
            else if (userInput == userNames[2] && passInput == passwords[2])
            {
                Console.WriteLine("You are logged in successfully");
            }
            else
            {
                Console.WriteLine("Incorrect username or password");
            }

            Console.ReadLine();

            #endregion
        }
    }
}
