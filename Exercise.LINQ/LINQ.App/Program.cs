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
            List<Dog> dogs = new List<Dog>()
        {
            new Dog("Charlie", "Black", 3, Race.Collie), // 0
	        new Dog("Buddy", "Brown", 1, Race.Doberman),
            new Dog("Max", "Olive", 1, Race.Plott),
            new Dog("Archie", "Black", 2, Race.Mutt),
            new Dog("Oscar", "White", 1, Race.Mudi),
            new Dog("Toby", "Maroon", 3, Race.Bulldog), // 5
	        new Dog("Ollie", "Silver", 4, Race.Dalmatian),
            new Dog("Bailey", "White", 4, Race.Pointer),
            new Dog("Frankie", "Gray", 2, Race.Pug),
            new Dog("Jack", "Black", 5, Race.Dalmatian),
            new Dog("Chanel", "Black", 1, Race.Pug), // 10
	        new Dog("Henry", "White", 7, Race.Plott),
            new Dog("Bo", "Maroon", 1, Race.Boxer),
            new Dog("Scout", "Olive", 2, Race.Boxer),
            new Dog("Ellie", "Brown", 6, Race.Doberman),
            new Dog("Hank", "Silver", 2, Race.Collie), // 15
	        new Dog("Shadow", "Silver", 3, Race.Mudi),
            new Dog("Diesel", "Brown", 4, Race.Bulldog),
            new Dog("Abby", "Black", 1, Race.Dalmatian),
            new Dog("Trixie", "White", 8, Race.Pointer), // 19
        };

            List<Person> people = new List<Person>()
        {
            new Person("Nathanael", "Holt", 20, Job.Choreographer),
            new Person("Rick", "Chapman", 35, Job.Dentist),
            new Person("Oswaldo", "Wilson", 19, Job.Developer),
            new Person("Kody", "Walton", 43, Job.Sculptor),
            new Person("Andreas", "Weeks", 17, Job.Developer),
            new Person("Kayla", "Douglas", 28, Job.Developer),
            new Person("Richie", "Campbell", 19, Job.Waiter),
            new Person("Soren", "Velasquez", 33, Job.Interpreter),
            new Person("August", "Rubio", 21, Job.Developer),
            new Person("Rocky", "Mcgee", 57, Job.Barber),
            new Person("Emerson", "Rollins", 42, Job.Choreographer),
            new Person("Everett", "Parks", 39, Job.Sculptor),
            new Person("Amelia", "Moody", 24, Job.Waiter)
            { Dogs = new List<Dog>() {dogs[16], dogs[18] } },
            new Person("Emilie", "Horn", 16, Job.Waiter),
            new Person("Leroy", "Baker", 44, Job.Interpreter),
            new Person("Nathen", "Higgins", 60, Job.Archivist)
            { Dogs = new List<Dog>(){dogs[6], dogs[0] } },
            new Person("Erin", "Rocha", 37, Job.Developer)
            { Dogs = new List<Dog>() {dogs[2], dogs[3], dogs[19] } },
            new Person("Freddy", "Gordon", 26, Job.Sculptor)
            { Dogs = new List<Dog>() {dogs[4], dogs[5], dogs[10], dogs[12], dogs[13] } },
            new Person("Valeria", "Reynolds", 26, Job.Dentist),
            new Person("Cristofer", "Stanley", 28, Job.Dentist)
            { Dogs = new List<Dog>() {dogs[9], dogs[14], dogs[15] } }
        };

            Console.ForegroundColor = ConsoleColor.Red;
            // Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            //LAMBDA
            var firstNameStartsR = people.OrderByDescending(person => person.Age)
                                                  .Where(person => person.FirstName.StartsWith('R'))    
                                                  .Select(person => person.FirstName)
                                                  .ToList();
            firstNameStartsR.ForEach(person => Console.WriteLine(person));

            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var firstNameStartsRQ = (from person in people
                                              where person.FirstName.StartsWith('R') 
                                              orderby person.Age descending 
                                              select person).Select(person =>  person.FirstName).ToList();
            firstNameStartsRQ.ForEach(person => Console.WriteLine(person));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            // Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            //LAMBDA
            var allBrownDogsOlder3 = dogs.Where(dog => dog.Color == "Brown" && dog.Age > 3).OrderBy(dog => dog.Age).Select(dog => $"{ dog.Name} {dog.Age }").ToList();
            allBrownDogsOlder3.ForEach(dog => Console.WriteLine(dog));

            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var allBrownDogsOlder3Q = (from dog in dogs 
                                                where dog.Color == "Brown" && dog.Age > 3 
                                                orderby dog.Age ascending 
                                                select $"{ dog.Name} { dog.Age}").ToList();
            allBrownDogsOlder3Q.ForEach(dog => Console.WriteLine(dog));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------------------------------------------------------");
            // Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            //LAMBDA
            var allPersonMore2Dogs = people.Where(person => person.Dogs.Count > 2)
                                                    .OrderByDescending(person => person.FirstName)                                               
                                                    .ToList();
            allPersonMore2Dogs.ForEach(person => Console.WriteLine(person.FirstName));

            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var allPersonMore2DogsQ = (from person in people
                                                where person.Dogs.Count > 2 
                                                orderby person.FirstName descending 
                                                select person).ToList();
            allPersonMore2DogsQ.ForEach(person => Console.WriteLine(person.FirstName));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            // Find and print all Freddy`s dogs names older than 1 year
            //LAMBDA
            var allFreddysDogsNamesOlder1 = people.SingleOrDefault(person => person.FirstName == "Freddy")
                                                            .Dogs.Where(dog => dog.Age > 1)
                                                            .Select(dog => dog.Name)
                                                            .ToList();
            allFreddysDogsNamesOlder1.ForEach(dog => Console.WriteLine(dog));

            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var allFreddysDogsNamesOlder1Q = (from person in people
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
            var firstDogNathan = people.SingleOrDefault(person => person.FirstName == "Nathen").Dogs
                                        .First();
            Console.WriteLine(firstDogNathan.Name);


            Console.WriteLine("-----------------------QUERY-------------------------------");
            //QUERY
            var firstDogNathanQ = (from person in people
                                   where person.FirstName == "Nathen"
                                   from dog in person.Dogs
                                   select dog.Name).First();
            Console.WriteLine(firstDogNathanQ);

            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            // Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
            //LAMBDA
            var allWhiteDogsCristoferFreddyErinAmelia = people.Where(person => person.FirstName == "Cristofer" ||
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
            var allWhiteDogsCristoferFreddyErinAmeliaQ = (from person in people
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
