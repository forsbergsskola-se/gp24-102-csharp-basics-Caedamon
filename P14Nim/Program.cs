Console.WriteLine("Hello and Welcome User!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name + "!");
Console.WriteLine("I am The artificial intelligence Jianshizi.");
Console.WriteLine("Which just so happens to also be the original version of the game we are gonna play today! NIM!");
Console.WriteLine("Now, Let me explain the game for you.");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("We have 20 matches total.");
Console.WriteLine("Each round Either You, or I, draw one to three of them.");
Console.WriteLine("The looser is the one whom draws the last match!");
Console.WriteLine("You, my dear " + name + ", get to go first!");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.Clear();


int totalMatches = 20;
int  currentPlayer = 1;
int takenMatches;

start:
Console.WriteLine($"\nCurrent sticks: {totalMatches}");
if (currentPlayer == 1)
    Console.WriteLine($"{currentPlayer}, Your Move.");
    retry:
    Console.WriteLine("How many Sticks would you like to draw? (1-3)");
    bool validInput = int.TryParse(Console.ReadLine(), out takenMatches);
    if (!validInput || takenMatches < 1 || takenMatches > 3 || takenMatches > totalMatches)
    {
        Console.WriteLine("Please enter a number between 1 and 3");
        goto retry;
    }
    else
    {
        Console.WriteLine("My turn!");
        takenMatches = CalculateAIMove(totalMatches);
        Console.WriteLine($"I've taken {takenMatches} matches!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.Clear();
    }

totalMatches -= takenMatches;
if (totalMatches <= 0)
    goto end;

currentPlayer = (currentPlayer == 1) ? 2 : 1;
goto start;

end:
if (currentPlayer == 1)
    Console.WriteLine($"\nPlayer {currentPlayer}, Game over, you took the last match!.");
else
    Console.WriteLine($"\nAI {currentPlayer}, You win! I took the last match!.");

Console.Clear();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
static int CalculateAIMove(int totalMatches)
{
    int move;
    if (totalMatches % 4 == 0)
        move = 1;
    else
        move = totalMatches % 4;
    return move > 3 ? 3 : move;
}