using System;

namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 01
            #region
            string word = "Number";
            string wordTwo = "One";
            var concat = word +" " + wordTwo;
            Console.WriteLine(concat);
      
            string one = "9";
            string two = "6";
            var gather = one + two;
            Console.WriteLine(gather);
            Console.ReadLine();

            #endregion
            //Exercise 02
            #region
            string txt = "U";
            int number = 2;
            var group = txt + number;
            Console.WriteLine(group);
            Console.ReadLine();
            #endregion
            //Exercise 03
            #region
            int n = 102;
            int m = 5;
            var result = n / m;
            Console.WriteLine(result);
            Console.ReadLine();

            #endregion
            //Exercise 04 (* BONUS)
            #region
            Console.Write("Input some number:");
            var inputNumber = Console.ReadLine();

            int numberValue;
            bool parseNum = int.TryParse(inputNumber, out numberValue);

            if(parseNum)
            {
                var oddEven = numberValue % 2 == 0 ? "even" : "odd";
                Console.WriteLine(oddEven);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.ReadLine();
            #endregion
        }
    }
}
