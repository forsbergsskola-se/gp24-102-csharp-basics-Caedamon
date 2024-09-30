/*
 Well... this didnt work xD
 apparantly, Ryder (or however you spell it) console window with its mat, grey tone, is classified as black -,,-
Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();
*/

Console.WriteLine("Hello and Welcome User!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.Clear();
Console.WriteLine("Hello " + name + "!");
Console.WriteLine("I am The artificial intelligence Jianshizi.");
Console.WriteLine("Which just so happens to also be the original version of the game we are gonna play today! NIM!");
Console.WriteLine("Now, Let me explain the game for you.");
Console.ReadKey();
Console.Clear();
Console.WriteLine("We have 20 matches total.");
Console.WriteLine("Each round Either You, or I, draw one to three of them.");
Console.WriteLine("The looser is the one whom draws the last match!");
Console.WriteLine("You, my dear " + name + ", get to go first!");
Console.ReadKey();
Console.Clear();

//basic information the "game" needs to be able to do what i want...
//not sure i should be making comments like this... is there a point?
int totalMatches = 20;
int  currentPlayer = 1;
int takenMatches;
Random random = new Random();


//The game!
start:
UpdateMatchDisplay(totalMatches);
Console.WriteLine($"\nCurrent matches: {totalMatches}");

for (int i = 0; i < totalMatches; i++)
{
    Console.Write("|");
}
Console.WriteLine();

if (currentPlayer == 1)
{
    Console.WriteLine("Your move.");
    retry:
    Console.WriteLine($"How many Matches would you like to draw, {name}? (1-3)");
    bool validInput = int.TryParse(Console.ReadLine(), out takenMatches);
    if (!validInput || takenMatches < 1 || takenMatches > 3 || takenMatches > totalMatches)
    {
        Console.WriteLine("Please enter a number between 1 and 3");
        goto retry;
    }
}
else
{
    Console.WriteLine("My turn!");
    takenMatches = CalculateAIMove(totalMatches, random);
    Console.WriteLine($"I've taken {takenMatches} matches!");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}

totalMatches -= takenMatches;
if (totalMatches <= 0)
    goto end;

currentPlayer = (currentPlayer == 1) ? 2 : 1;
goto start;


//end message
end:
Console.WriteLine();
if (currentPlayer == 1)
{
    Console.WriteLine($"Game over {name}, you took the last match!");
}
else
{
    Console.WriteLine($"Damnit! You win this time {name}! I took the last match!.");
}
Console.WriteLine("Press any key to exit...");
Console.ReadKey();


//remaking AI, Leaving this as origin AI code... ITS TO DAMN STUPID! xD
/*
static int CalculateAIMove(int totalMatches, Random random)
{
    int move = random.Next(1, Math.Min(4, totalMatches +1));
    return move;
}
*/

//slightly less retarded AI -,,-
//It bugs me enormously that i have to put in so many lines of codes for this!
static int CalculateAIMove(int totalMatches, Random random)
{
    int move;
    
    if (totalMatches == 4)
    {
        move = 3;
    }
    else if (totalMatches == 3)
    {
        move = 2;
    }
    else if (totalMatches == 2)
    {
        move = 1;
    }
    else
    {
        move = random.Next(1, Math.Min(4, totalMatches +1));
    }
    return move;
}
// Collors for text =P
static void UpdateMatchDisplay(int totalMatches)
{
    if (totalMatches >= 10)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    else if (totalMatches >= 4)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
}
