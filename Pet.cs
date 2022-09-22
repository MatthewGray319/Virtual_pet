using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
       

    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public Pet()
        {
            Name = "Jackson";
            Species = "Dog";
            Hunger = 60;
            Boredom = 60;
            Health = 60;  

	    }

        public Pet (string name, string species, int hunger, int boredom, int health)
        {
            Name = name;
            Species = species;
            Hunger = 60;
            Boredom = 60;
            Health = 60;
	    }

        public static Pet RandomPet()
        {
            Random rng = new Random();
            List<string> names = new List<string>() { "Leo", "Samantha", "Buddy", "Franky", "Ruby", "Matt", "Zak", "Jack", "Bob", "Larry" };
            List<string> species = new List<string>() { "Cat", "Dog", "Lion", "Fish", "Bird", "Monkey", "Hampster", "Lobster", "Goat", "Zebra" };
            return new Pet(names[rng.Next(names.Count)], species[rng.Next(species.Count)], 60, 60, 60);
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}, Health: {Health}, Boredom: {Boredom}, Hunger: {Hunger}");
	    }
        public string ToStringRepresentation()
        {
            return $"Name: {Name}, Species: {Species}, Health: {Health}, Boredom: {Boredom}, Hunger: {Hunger}";
        }

        public void Feed()
        {
            Hunger -= 10;
	    }
        
        public void SeeDoctor()
        {
            Health += 30;
	    }

        public void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
	    }

        public void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
	    }

      
    }
}
