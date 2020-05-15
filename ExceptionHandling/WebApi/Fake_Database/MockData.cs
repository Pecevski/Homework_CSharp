using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.Fake_Database
{
    internal static class MockData
    {
        internal static List<User> GetMockedUsers()
        {
            User john = new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };
            User bob = new User()
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Bobsky"
            };
            User mark = new User()
            {
                Id = 3,
                FirstName = "Mark",
                LastName = "Dean",
                Friends = new List<User>() { john, bob }
            };
            User harry = new User()
            {
                Id = 4,
                FirstName = "Harry",
                LastName = "O'Connel",
                Friends = new List<User>() { mark }
            };
            User jina = new User()
            {
                Id = 5,
                FirstName = "Jina",
                LastName = "Johnson",
                Friends = new List<User>() { harry, bob, john }
            };
            return new List<User>() { john, bob, harry, mark, jina };
        }

        internal static List<Admin> GetAdmins()
        {
            Admin cekikj = new Admin()
            {
                Id = 1,
                FirstName = "Miki",
                LastName = "Cekikj"
            };
            Admin goce = new Admin()
            {
                Id = 2,
                FirstName = "Goce",
                LastName = "Kabov",
                Supervisor = new List<Admin>() { cekikj}
            };
            Admin marko = new Admin()
            {
                Id = 3,
                FirstName = "Marko",
                LastName = "Jarikj",  
                Supervisor = new List<Admin>() { cekikj, goce}
            };
            Admin ilija = new Admin()
            {
                Id = 4,
                FirstName = "Ilija",
                LastName = "Pecevski",  
                Supervisor = new List<Admin>() { cekikj, goce}
            };
            Admin drazen = new Admin()
            {
                Id = 5,
                FirstName = "Drazen",
                LastName = "Petrovic",
                Supervisor = new List<Admin>() { cekikj, goce , ilija}
            };
            return new List<Admin>() { cekikj, goce, ilija, marko, drazen };
        }
    }
}
