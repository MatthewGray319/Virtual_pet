// Your Program Code Here
using template_csharp_virtual_pet;

Console.WriteLine("Welcome to Virtual Pet!");

var pets = new List<Pet>();
Pet activePet = new Pet();
Console.WriteLine("Start by creating your first pet!");
Console.WriteLine("What is your pet's name?");
activePet.Name = Console.ReadLine();
Console.Clear();
Console.WriteLine("What is the species of your pet?");
activePet.Species = Console.ReadLine();
Console.Clear();
bool isRunning = true;
while (isRunning)
{

   
    Console.WriteLine($"Great! Your first pet is a {activePet.Species} and its name is {activePet.Name}. Currently it has {activePet.Health} health, {activePet.Boredom} boredom, and a hunger level of {activePet.Hunger}!\n");
    Console.WriteLine($"You can take {activePet.Name} to the doctor to increase health, feed {activePet.Name} to decrease their hunger level, or play with {activePet.Name} to decrease their boredom!\nSelect from the options below to continue!\n");
    Console.WriteLine("1. Feed\n2. Play\n3. See Doctor!\n4. See the status of your pet!\nPress Q to Quit!");
    activePet.Tick();

    string userChoice = Console.ReadLine().ToLower();
    switch (userChoice)
    {
        case "1":
            Console.Clear();
            activePet.Feed();
            Console.WriteLine($"Thanks for feeding {activePet.Name}, his hunger is now {activePet.Hunger}!\n");
            Console.WriteLine("Press enter to return!");
            Console.ReadLine();
            break;
        case "2":
            Console.Clear();
            activePet.Play();
            Console.WriteLine($"Thanks for playing with {activePet.Name}, their boredome level is now {activePet.Boredom}!\n");
            Console.WriteLine("Press enter to return!");
            Console.ReadLine();
            break;
        case "3":
            Console.Clear();
            activePet.Tick();
            activePet.SeeDoctor();
            Console.WriteLine($"Thanks for taking {activePet.Name} to the doctor! Their health has increased but they have gotten more hungry and more bored!\n");
            Console.WriteLine("Press enter to return!");
            Console.ReadLine();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine($"Your {activePet.Species}, {activePet.Name} has a hunger level of {activePet.Hunger}, a boredom level of {activePet.Boredom} and a health level of {activePet.Health}!");
            if (activePet.Hunger > 75)
            {
                Console.WriteLine($"You better feed {activePet.Name}, they are hungry!");
	        }
            if (activePet.Health < 30)
            {
                Console.WriteLine($"You better take {activePet.Name} to see the doctor!");
	        }
            if (activePet.Boredom > 75)
            {
                Console.WriteLine($"{activePet.Name} is getting bored. You should play with them!");
	        }
            Console.WriteLine("\nPress enter to return!");
            Console.ReadLine();
            break;
        case "q":
            isRunning = false;
            Console.WriteLine("Goodbye!");
            break;
    }
}

