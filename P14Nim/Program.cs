Console.WriteLine("Hello and Welcome User!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name + "!");
Console.WriteLine("I am The artificial intelligence Jianshizi.");
Console.WriteLine("Which just so happens to also be the origin version of the game we are gonna play today! NIM!");
Console.WriteLine("Now, Let me explain the game for you.");
Console.WriteLine("We have 20 matches total.");
Console.WriteLine("Each round Either You, or I, draw one to three of them.");
Console.WriteLine("The looser is the one whom draws the last match!");
Console.WriteLine("You, my dear " + name + ", get to go first!");


int totalSticks = 20;
string currentPlayer = name;
int takenSticks;

start:
Console.WriteLine($"\nCurrent sticks: {totalSticks}");
Console.WriteLine($"{currentPlayer}, Your Move.");

retry:
Console.WriteLine("How many Sticks would you like to draw? (1-3)");
Console.WriteLine();


end:


















Console.Clear();
Console.WriteLine("Game over.");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();