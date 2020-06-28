using DocumentFormat.OpenXml.Wordprocessing;
using Exercise.Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise.Generics
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets;
        public PetStore()
        {
            Pets = new List<T>();
        }
        public void PrintsPets()
        {
            foreach (T pet in Pets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }
        public void BuyPet(string name)
        {
            T petName = Pets.FirstOrDefault(p => p.Name == name);

            if (petName == null)
            {
                Console.WriteLine("There is no pet with that name!");
            }
            else
            {
                Pets.Remove(petName);
                Console.WriteLine($"You bought a pet with name  {petName.Name}!");
                
            }
            
        }
    }
}
