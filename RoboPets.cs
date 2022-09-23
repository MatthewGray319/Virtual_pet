using System;
namespace template_csharp_virtual_pet
{
    public class RoboPets : GamePets
    {
        public int Charge { get; set; }
        

        public RoboPets()
        {
            Name = "Zakatron";
            Species = "Robot";
            Charge = 1000;
            Boredom = 60;
            Health = 100;
            Hunger = 100;
        }

        public RoboPets(string name, string species, int charge)
        {
            Name = name;
            Species = species;
            Charge = charge;
	    }

        public static RoboPets RandomRobo()
        {
            Random rng = new Random();
            List<string> names = new List<string>() { "LeoTron", "SamanthaTron", "BuddyTron", "FrankyTron", "RubyTron", "MattTron", "ZakTron", "JackTron", "BobTron", "LarryTron" };
            return new RoboPets(names[rng.Next(names.Count)], "Robot" , 1000);
	    }

        public override string ToStringRepresentation()
        {
            return $"Name: {Name}, Species: {Species}, Charge: {Charge}";
        }

        public override void Play()
        {
            Charge -= 100;
            Boredom -= 15;
        }

        public override void SeeDoctor()
        {
            Charge += 200;
            Health += 200;
        }

        public override void Tick()
        {
            Charge -= 25;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}, Charge: {Charge}, Boredom: {Boredom}, Health: {Health}");
        }

        public override void Feed()
        {
            Charge += 20;
            Health += 25;
        }
    }
}


