using LINQ.App.Entities;
using LINQ.App.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            // Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            //LAMBDA
            var firstNameStartsR = DB.people.OrderByDescending(person => person.Age)
                                                  .Where(person => person.FirstName.StartsWith('R'))    
                                                  .Select(person => person.FirstName)
                                                  .ToList();
            firstNameStartsR.ForEach(person => Console.WriteLine(person));

            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var firstNameStartsRQ = (from person in DB.people
                                              where person.FirstName.StartsWith('R') 
                                              orderby person.Age descending 
                                              select person).Select(person =>  person.FirstName).ToList();
            firstNameStartsRQ.ForEach(person => Console.WriteLine(person));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            // Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            //LAMBDA
            var allBrownDogsOlder3 = DB.dogs.Where(dog => dog.Color == "Brown" && dog.Age > 3).OrderBy(dog => dog.Age).Select(dog => $"{ dog.Name} {dog.Age }").ToList();
            allBrownDogsOlder3.ForEach(dog => Console.WriteLine(dog));

            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var allBrownDogsOlder3Q = (from dog in DB.dogs 
                                                where dog.Color == "Brown" && dog.Age > 3 
                                                orderby dog.Age ascending 
                                                select $"{ dog.Name} { dog.Age}").ToList();
            allBrownDogsOlder3Q.ForEach(dog => Console.WriteLine(dog));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------");
            // Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            //LAMBDA
            var allPersonMore2Dogs = DB.people.Where(person => person.Dogs.Count > 2)
                                                    .OrderByDescending(person => person.FirstName)                                               
                                                    .ToList();
            allPersonMore2Dogs.ForEach(person => Console.WriteLine(person.FirstName));

            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var allPersonMore2DogsQ = (from person in DB.people
                                                where person.Dogs.Count > 2 
                                                orderby person.FirstName descending 
                                                select person).ToList();
            allPersonMore2DogsQ.ForEach(person => Console.WriteLine(person.FirstName));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            // Find and print all Freddy`s dogs names older than 1 year
            //LAMBDA
            var allFreddysDogsNamesOlder1 = DB.people.SingleOrDefault(person => person.FirstName == "Freddy")
                                                            .Dogs.Where(dog => dog.Age > 1)
                                                            .Select(dog => dog.Name)
                                                            .ToList();
            allFreddysDogsNamesOlder1.ForEach(dog => Console.WriteLine(dog));

            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var allFreddysDogsNamesOlder1Q = (from person in DB.people
                                                       where person.FirstName == "Freddy"
                                                       from dog in person.Dogs
                                                              where dog.Age > 1
                                                              select dog.Name)
                                                              .ToList();
            allFreddysDogsNamesOlder1Q.ForEach(dog => Console.WriteLine(dog));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------");
            // Find and print Nathen`s first dog
            //LAMBDA
            var firstDogNathan = DB.people.SingleOrDefault(person => person.FirstName == "Nathen").Dogs
                                        .First();
            Console.WriteLine(firstDogNathan.Name);


            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var firstDogNathanQ = (from person in DB.people
                                   where person.FirstName == "Nathen"
                                   from dog in person.Dogs
                                   select dog.Name).First();
            Console.WriteLine(firstDogNathanQ);

            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            // Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
            //LAMBDA
            var allWhiteDogsCristoferFreddyErinAmelia = DB.people.Where(person => person.FirstName == "Cristofer" ||
                                                                     person.FirstName == "Freddy" ||
                                                                     person.FirstName == "Erin" ||
                                                                     person.FirstName == "Amelia")
                                                              .SelectMany(person => person.Dogs)
                                                              .Where(dog => dog.Color == "White")
                                                              .OrderBy(dog => dog.Name)
                                                              .Select(dog => dog.Name)
                                                              .ToList();
            allWhiteDogsCristoferFreddyErinAmelia.ForEach(dog => Console.WriteLine(dog));
            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var allWhiteDogsCristoferFreddyErinAmeliaQ = (from person in DB.people
                                                          where person.FirstName == "Cristofer" ||
                                                                     person.FirstName == "Freddy" ||
                                                                     person.FirstName == "Erin" ||
                                                                     person.FirstName == "Amelia"
                                                          from dog in person.Dogs
                                                          where dog.Color == "White"
                                                          orderby dog.Name select dog.Name).ToList();
            allWhiteDogsCristoferFreddyErinAmeliaQ.ForEach(dog => Console.WriteLine(dog));



            Console.ReadLine();
        }
    }
}
