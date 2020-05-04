using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Login_Register_App
{
    public class User
    {
        public Dictionary<string, string> UserNamePassword { get; set; }

        public User()
        {
            UserNamePassword = new Dictionary<string, string>();

            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            bool successfull = false;
            
            Dictionary<string, string> arrUsers = new Dictionary<string, string>();
            arrUsers.Add("ilija@domain.com", "Stasi1505#!");
            arrUsers.Add("random@domain.com", "Don@Joe12!");
           
            var admin = "admin@admindomain.com";
            var adminPass = "Ad#mi8$s@!";

            while (!successfull)
            {
                Console.WriteLine("Select if you want to Register or Login!");
                Console.WriteLine("1 - REGISTER");
                Console.WriteLine("2 - LOGIN");
                Console.WriteLine("3 - ADMIN");
                Console.WriteLine("4 - LOGOUT");
                Console.WriteLine("5 - EXIT APP");
                string optionOne = Console.ReadLine();

                switch (optionOne)
                {
                    case "1":
                
                        Console.WriteLine("Register user:");
                        Console.WriteLine("Write your username:");
                        var username = Console.ReadLine();
                        var emailPattern = new Regex (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,30})+)$");

                        Console.WriteLine("Enter your password:");
                        var password = Console.ReadLine();
                        var passPattern = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{10,}$");

                        if (emailPattern.IsMatch(username) && passPattern.IsMatch(password))
                        {
                            Console.WriteLine("You have successfully registered !");
                            Console.ReadLine();
                            arrUsers.Add(username, password);
                            
                            successfull = true;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Your username or password  is incorrect, try again !");
                            Console.ReadLine();

                        }

                        break;

                    case "2":

                        Console.WriteLine("Login user:");
                        Console.WriteLine("Enter your username:");
                        var userEmail = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        var loginPass = Console.ReadLine();

                        if (arrUsers.ContainsKey(userEmail))
                        {
                            foreach (var user in arrUsers)
                            {

                                var pattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,30})+)$");
                                var logPattern = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{10,}$");

                                if (pattern.IsMatch(userEmail) && logPattern.IsMatch(loginPass) && pattern.IsMatch(user.Key) && logPattern.IsMatch(user.Value))
                                {
                                    Console.WriteLine("You are logged in !");
                                    Console.ReadLine();
                                    successfull = true;
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("Your username or password  is incorrect, try again !");
                                    Console.ReadLine();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No user available!");
                        }

                        break;

                    case "3":

                        Console.WriteLine("Please, input admin mail:");                        
                        var adminEmail = Console.ReadLine();

                        Console.WriteLine("Please, input admin password:");
                        var adminPassword = Console.ReadLine();

                        if (adminEmail == admin && adminPassword == adminPass)
                        {
                            Console.WriteLine("Welcome Admin! Make your choise!");
                            Console.WriteLine("1 - List of all Users");
                            Console.WriteLine("2 - Delete User");
                            string optionAdmin = Console.ReadLine();
                            successfull = true;
                            switch (optionAdmin)
                            {
                                case "1":
                                    foreach (var user in arrUsers)
                                    {
                                        Console.WriteLine(user);
                                        Console.ReadLine();
                                    }                                    
                                    break;
                                case "2":
                                    Console.WriteLine("Provide users email which you want to delete!");
                                    var userToDelete = Console.ReadLine();
                                    
                                    if (arrUsers.ContainsKey(userToDelete))
                                    {
                                        
                                        arrUsers.Remove(userToDelete);
                                        Console.WriteLine("User is deleted!");
                                        Console.ReadLine();

                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Such user does not exist!");
                                        Console.ReadLine();

                                    }

                                    break;
                                default:
                                    Console.WriteLine("Wrong choice, try again!");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry admin, username or password is incorrect! Try again!");

                        }
                        break;

                    case "4":
                        Console.WriteLine("Would you like to logout? Input logout if so! ");
                         
                        if (Console.ReadLine() == "logout")
                        {
                            successfull = false;
                            Console.WriteLine("Logged out! Please make another choice!");
                            Console.ReadLine();
                        }
                        break;

                    case "5":
                        Console.WriteLine("Input exit if you want to end this app!");
                        if (Console.ReadLine() == "exit")  return;
                                                                        
                        break;

                    default:
                
                        Console.WriteLine("You have made non available choice! Choose between 1-5.");
                        Console.ReadLine();
                        break;
                }
                Console.ReadLine();

            }              
        }            
    }
}
