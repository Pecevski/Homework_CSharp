using System;

namespace Homework_String
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK 01 Print individual characters of the string in reverse order.

            string sentence = "We love c#.";
            string reverse = "";
            int length;

            length = sentence.Length - 1;
            for (int i = length; i >= 0; i--)
            {
                reverse = reverse + sentence[i];
            }

            Console.WriteLine(reverse);

            Console.ReadLine();
            #endregion

            #region TASK 02 Count the total number of words in a string entered by the user. 
            Console.WriteLine("Input a sentence: ");
            string userInput = Console.ReadLine();
            string[] wordCount = userInput.Trim().Split(' ');

            Console.WriteLine("Number of words in the string = {0}", wordCount.Length);

            Console.ReadLine();
            #endregion

            #region TASK 03 Find maximum occurring character in a string
            string korona = "We want this situation with covid-19 to ends!";
            char[] array = korona.ToCharArray();

            string maxChar = " ";
            int maxCount = 0;

            foreach (var letter in array)
            {
                int currentCounter = 0;
                if (!Char.IsWhiteSpace(letter))
                {
                    foreach (var currentLetter in array)
                    {
                        if (letter == currentLetter)
                        {
                            currentCounter++;
                        }
                    }

                    if (currentCounter > maxCount)
                    {
                        maxChar = letter.ToString();
                        maxCount = currentCounter;
                    }
                }
            }

            //Console.WriteLine(array.Length);
            Console.WriteLine("The highest frequency of character {0} appears number of times : {1} ", maxChar, maxCount);
            Console.ReadLine();


            #endregion

            #region TASK 04 Print the whole text after "," in the console. 

            string sentenceTest = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";

            string[] splitting = sentenceTest.Split(new char[] {',' });

            Console.WriteLine(splitting[1]);
            Console.ReadLine();

            #endregion

            #region TASK 05 Display the Day properties (year, month, day, hour, minute, second) from the today's date.

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            Console.WriteLine($"Year : {year}, Month: {month}, Day: {day}, Hour: {hour}, Minute: {minute}, Second: {second}.");
            Console.ReadLine();

            #endregion

            #region TASK 06 Find the leap years between 2008 and 2020.

            int y;

            for (y = 2008; y <= 2020; y++)
            {
                if (DateTime.IsLeapYear(y))
                {
                    Console.WriteLine($"{y} is leap year!");
                }
            }
            Console.ReadLine();
            #endregion


        }
    }
}
