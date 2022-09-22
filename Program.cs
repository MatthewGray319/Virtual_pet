// Your Program Code Here
using System.Collections.Concurrent;
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
pets.Add(activePet);
Console.Clear();
bool isRunning = true;
while (isRunning)
{

   
    Console.WriteLine($"Great! Your first pet is a {activePet.Species} and its name is {activePet.Name}. Currently it has {activePet.Health} health, {activePet.Boredom} boredom, and a hunger level of {activePet.Hunger}!\n");
    Console.WriteLine($"You can take {activePet.Name} to the doctor to increase health, feed {activePet.Name} to decrease their hunger level, or play with {activePet.Name} to decrease their boredom!\nSelect from the options below to continue!\n");
   
    Console.WriteLine("1. Feed\n2. Play\n3. See Doctor!\n4. See the status of your pet!\n5. Visit the shelter!\nPress Q to Quit!");
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
            if (activePet.Hunger < 60)
            {
                Console.WriteLine($"You better feed {activePet.Name}, they are hungry!");
	        }
            if (activePet.Health < 30)
            {
                Console.WriteLine($"You better take {activePet.Name} to see the doctor!");
	        }
            if (activePet.Boredom < 60)
            {
                Console.WriteLine($"{activePet.Name} is getting bored. You should play with them!");
	        }
            Console.WriteLine("\nPress enter to return!");
            activePet.Tick();
            Console.ReadLine();
            break;
        case "5":
            Console.Clear(); 
            Console.WriteLine("Welcome to the shelter!\nWhat would you like to do?\n1. Adopt a pet\n2. Swap pets\n3. View All pets");
            var shelterChoice = Console.ReadLine();
            switch (shelterChoice)
            {
                case "1":
                    Console.Clear();
                    Pet toBuy = Pet.RandomPet();
                    toBuy.Display();
                    Console.WriteLine($"Would you like to adopt {toBuy.Name}? (Y/N)");
                    var response = Console.ReadLine().ToLower();
                    if (response == "y")
                    {
                        Console.WriteLine($"Congrats! {toBuy.Name} is now your new pet!");
                        pets.Add(toBuy);
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
		            }
                    else
                    {
                        Console.WriteLine("Thanks for coming, see you next time!");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadKey();
		            }
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("What pet would you like to swap to?");
                    for (int i = 0; i < pets.Count; i++)
                    {
                        Console.WriteLine($"Pet# {i+1}\n {pets[i].ToStringRepresentation()}\n");

                    }
                    var swapPet = int.Parse(Console.ReadLine());
                    activePet = pets[swapPet - 1];
                    Console.WriteLine($"Your new active pet is {activePet.Name} the {activePet.Species}");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Here are all of your pets and their current status.\nYou can also choose to interact with all pets at once!");
                    for (int i = 0; i < pets.Count; i++)
                    { 
		                Console.WriteLine($"Pet # {i+1}\n {pets[i].ToStringRepresentation()}");
		            }
                    Console.WriteLine("1. Feed all pets\n2. Take all pets to the doctor\n3. Play with all pets!");
                    var allPetChoice = Console.ReadLine();
                    switch (allPetChoice)
                    {
                        case "1":
                            Console.Clear();
                            foreach (Pet pet in pets)
                            {
                                pet.Feed();
                            }
                            Console.WriteLine("Thanks for feeding your pets!");
                            break;
                        case "2":
                            Console.Clear();
                            foreach (Pet pet in pets)
                            {
                                pet.SeeDoctor();
			                }
                            Console.WriteLine("Thanks for taking your pets to the doctor!");
                            break;
                        case "3":
                            Console.Clear();
                            foreach (Pet pet in pets)
                            {
                                pet.Play();
			                }
                            Console.WriteLine("Thanks for playing with your pets! They are now less bored.");
                            break;
			            
		            }
                    Console.WriteLine("\nPress Enter to return");
                    Console.ReadKey();
                    break;


	        }

            break;
        case "q":
            isRunning = false;

            Console.WriteLine("Goodbye!");
            break;
    }
}
