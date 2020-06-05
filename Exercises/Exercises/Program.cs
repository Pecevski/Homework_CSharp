using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercises 1
           
            List<string> Names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter your name: ");
                string inputName = Console.ReadLine().ToLower();

                if (inputName == "x")
                {
                    break;
                }
                else
                {
                    Names.Add(inputName);
                }                
            }

            Console.WriteLine("Input your text: ");
            string inputText = Console.ReadLine().ToLower();
            //List<string> Text = new List<string>();
            string [] text = inputText.Split(" ").ToArray();

            foreach (var name in Names)
            {
                var counter = text.Count(t => t.Contains(name));
                
                Console.WriteLine($"Names {name} has been counted {counter} times in the text.");
            }


            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------");
            #endregion

            #region Exercise 2
            //2. create an aplication that checks if a day is a working day or not
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter a day(example: 1, 15, 18):");
            var inputedDay = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a month(example: 5, 10, 2):");
            var inputedMonth = int.Parse(Console.ReadLine());

            var inputDate = $"{inputedDay}.{inputedMonth}";
            string[] holidays = { "1.1", "7.1", "20.4", "1.5", "25.5", "2.8", "8.9", "12.10", "23.10", "8.12" };

            while (true)
            {
                try
                {
                    DateTime convertDayToString = new DateTime(2020, inputedMonth, inputedDay); //year, month, day
                    var day = convertDayToString.ToString("dddd");

                    if (day == "Saturday" || day == "Sunday")
                    {
                        Console.WriteLine("The date you inputted is weekend!");
                    }
                    else if (holidays.Contains(inputDate))
                    {
                        Console.WriteLine("The date you inputted isn't a working day, it's a holiday!");
                    }
                    else
                    {
                        Console.WriteLine("The date you inputted is a working day!");
                    }
                    break;
                   
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong date.Try again!");
                    break;
                }
               
            }
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------------------------");
            #endregion

            #region Exercise 3
            Console.ForegroundColor = ConsoleColor.White;
            string inputPlayer;
            string inputPC = null;
            int randomPC;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scorePC = 0;

                while (scorePlayer < 5 && scorePC < 5)
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();
                    randomPC = rnd.Next(1, 4);

                    switch (randomPC)
                    {
                        case 1:
                            inputPC = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PC WINS!!");
                                scorePC++;
                            }
                            break;
                        case 2:
                            inputPC = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PC WINS!!");
                                scorePC++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputPC = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PC WINS!!");
                                scorePC++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"SCORES: PLAYER:{scorePlayer}  PC:{scorePC}");

                    int playerPercentage;
                    int percentagePC;
                    if (scorePlayer == scorePC)
                    {
                        playerPercentage = 50;
                        percentagePC = 50;
                    }
                    else
                    {
                        playerPercentage = scorePlayer * (100 / (scorePlayer + scorePC));
                        percentagePC = 100 - playerPercentage;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"STATS: PLAYER-STAT: {playerPercentage}%  PC-STATS:{percentagePC}%");

                }              

                Console.WriteLine("If you don't want to play again type: exit.");
                string loop = Console.ReadLine().ToLower();
                if (loop == "exit")
                {
                    playAgain = false;
                    
                }
                else 
                {
                    playAgain = true;
                    Console.Clear();
                }
                
            }

            #endregion
        }
    }
}
