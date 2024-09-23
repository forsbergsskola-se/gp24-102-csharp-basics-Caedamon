// See https://aka.ms/new-console-template for more information
/*
    Instructions
    Create a Console Project named P12Random How To?
    Ask the User for a Seed and store it in a variable.
    Initialize Random with the given Seed.
    Get three Random Numbers between 0 and 5 (including 0, excluding 5) and print them to the Console.
    Get three Random Numbers between 0 and 0.5 (including 0, excluding 0.5) and print them to the Console.
    Get three Random Numbers between 0.2 and 0.7 (including 0.2, excluding 0.7) and print them to the Console.
    Ask the user for a Critical Hit Chance between 0.0 (0%) and 1.0 (100%).
    Then simulate 5 Attacks where you roll for the Critical Hit Chance and print, whether it’s a Critical Hit. Or No Critical Hit.
    Hint: Thanks to using the Seed, you should actually receive the same results as me, if using the same Seed. Test it! :)
*/

Console.WriteLine("This is your Friendly AI-Borg");
Console.WriteLine("We are doing battle today!");
Console.WriteLine("We Are The Borg.");
Console.WriteLine("Resistance is Futile, you Will be Assimilated!");
Console.WriteLine("Ima gonna have to ask you for a Seed number");

string input = Console.ReadLine();
int seed;
while (!int.TryParse(input, out seed))
{
 Console.WriteLine("Gonna need a number for that Seed, Human...");
 input = Console.ReadLine();
}

Random random = new Random(seed);

Console.Clear();

Console.WriteLine("Three integers between 0 and 5:");
for (int i = 0; i < 3; i++)
{
 int randomInt = random.Next(0, 5);
 Console.WriteLine(randomInt);
}

Console.ReadKey();
Console.Clear();

Console.WriteLine("Three numbers between 0.0 and 0.5:");
for (int i = 0; i < 3; i++)
{
 double randomDouble = random.NextDouble() * 0.5;
 Console.WriteLine(randomDouble);
}

Console.ReadKey();
Console.Clear();

Console.WriteLine("Three numbers between 0.2 and 0.7:");
for (int i = 0; i < 3; i++)
{
 double randomDouble = random.NextDouble() * (0.7 - 0.2) + 0.2;
 Console.WriteLine(randomDouble);
}

Console.ReadKey();
Console.Clear();

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double critChance = double.Parse(Console.ReadLine());

Console.WriteLine("Simulating 5 attacks:");
for (int i = 0; i < 5; i++)
{
 double roll = random.NextDouble();
 if (roll < critChance)
 {
  Console.WriteLine("Attack {0}: Critical Hit!", i + 1);
 }
 else
 {
  Console.WriteLine("Attack {0}: No Critical Hit.", i + 1);
 }
}

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
//P12_1Random_Coordinates
//Develop a program that generates random X and Y coordinates for an enemy in a 2D game world with 100x100 coordinates. Display these coordinates to the user.
//

Console.WriteLine("This is your Friendly AI-Borg");
Console.WriteLine("We are doing battle today!");
Console.WriteLine("We Are The Borg.");
Console.WriteLine("Resistance is Futile, you Will be Assimilated!");
Console.WriteLine("Today we are doing SPACE BATTLE!");
Console.WriteLine("The Grid is a 100 by 100 size");
Console.WriteLine("Now give me a new Seed number!");

string inputCords = Console.ReadLine();
int seedCords;
while (!int.TryParse(inputCords, out seedCords))
{
 Console.WriteLine("Gonna need a number for that Seed, Human...");
 inputCords = Console.ReadLine();
}

Random randomCords = new Random(seedCords);
Console.WriteLine("Your BattleShip is on these coordinates!");
int x = randomCords.Next(1, 100);
int y = randomCords.Next(1, 100);

Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
// P12_2Random_Password
// Design a program that generates a random password with 6 characters, digits or symbols.
//

Console.WriteLine("We Are The Borg.");
Console.WriteLine("Resistance is Futile, you Will be Assimilated!");
Console.WriteLine("Ima gonna give you a password so you can semi-safely log in to our Borg.Net");
Console.WriteLine("Now give me a new Seed number that i will base your password off of!");

string inputPSW = Console.ReadLine();
int seedPSW;
while (!int.TryParse(inputPSW, out seedPSW))
{
 Console.WriteLine("Gonna need a number for that Seed, Human...");
 inputPSW = Console.ReadLine();
}

Random randomPSW = new Random(seedPSW);
const string chars = "qazwsxedcrfvtgbyhnujmiklpöåäQAZWSXEDCRFVTGBYHNUJMKLPÖÅÄ23456789!#¤%&/()=?`@£$€{[]}^*";
// 0Oo and I1 removed since they are hard to differentiate between unless you CopyPasta

string password = "";

for (int i = 0; i < 6; i++)
{
 char randomChar = chars[randomPSW.Next(0, chars.Length)];
 password += randomChar;
}

Console.WriteLine("Generated Password: " + password);
Console.WriteLine("You can now safely log into Borg.Net/AssimilationAcquired");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
// P12_3Random_Item
// Write a program that simulates item drops in a game. Define five different items, and randomly select an item for the player to acquire.
//

Console.WriteLine("We Are The Borg.");
Console.WriteLine("Resistance is Futile, If you havent already been assimilated, you WILL be!");
Console.WriteLine("As a newly assimilated Borg, we will now grant you the use of a number of items randomly picked by the Borg from our armory!");
Console.WriteLine("Now give me a new Seed number that i will base your password off of!");

string inputArms = Console.ReadLine();
int seedArms;
while (!int.TryParse(inputArms, out seedArms))
{
 Console.WriteLine("Gonna need a number for that Seed, Human...");
 inputArms = Console.ReadLine();
}

Random randomItems = new Random(seedArms);
string[] items =
{
 "Phaser Blaster, ", 
 "Autonomous Regeneration Sequencer, ", 
 "Multi-Regenerative Shield Array, ", 
 "Nano-Probes, ", 
 "Radiation Emitter, "
}; 

int drop = 3;

Console.WriteLine("You have been granted the following from the Armory: ");

for (int i = 0; i < drop; i++)
{
 string droppedItem = items[randomItems.Next(0, items.Length)];
 Console.WriteLine("- " + droppedItem);
}

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
// P12_4Random_Chance
// Write a program that has a 10% chance of showing a secret message. Otherwise it just displays a message saying to try again.
//

//Console.WriteLine("We Are The Borg.");
//Console.WriteLine("Resistance is Futile, you are assimilated, right?");
//Console.WriteLine("");


//Console.WriteLine("Press any key to continue...");
//Console.ReadKey();
//Console.Clear();