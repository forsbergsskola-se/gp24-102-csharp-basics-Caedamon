



/* Exercises 13 - Go To
    Final Exercise
    Goal
Output:I have picked a number (1-100). It's your turn to guess it!
Input:32
Output:Nope! My number is Greater!
Input:60
Output: Nope! My number is Smaller!
Input:42
Output: That's the number! Well played!
Instructions
    Create a Console Project named P13GoTo How To?
    Follow the instructions of the pseudo-code below
    Then see if you can simplify the code a bit
using if...else if...else
Bonus: Add a Try-Counter. Tell the User, how many guesses he needed.
    Bonus: Add a Maximum Try Number. After 10 attempts, the Player loses.
    PSEUDOCODE:
myNumber := random number between 1 and 100
explain rules to user
USER_TURN:
ask user for number
guess := user input

if myNumber is less than guess then
tell user to guess lower
    go back to USER_TURN
    end if

if myNumber is greater than guess then
tell user to guess higher
    go back to USER_TURN
    end if

if myNumber is equal to guess then
tell user he won
end if
*/

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Time for a Seed Input!");
string seedIn = Console.ReadLine();

int seed;
while (!int.TryParse(seedIn, out seed))
{
    Console.WriteLine("Write a valid number, 1-100 please!");
    seedIn = Console.ReadLine();
}

Random random = new Random(guess);
int myNumber = random.Next(1, 100);

User_Turn:
Console.WriteLine("Well, Guess my number! its between 1 and a 100.");
string guessIn = Console.ReadLine();
int guess;

if (myNumber < guess)
{    
    Console.WriteLine("Yeah no, thats not it, its a lower number! Try again.");
    goto User_Turn;
}
if (myNumber > guess)
{
    Console.WriteLine("Yeah no, thats not it, guess higher. Try again.");
    goto User_Turn;
}
if (myNumber == guess)
{
    Console.WriteLine("Thats it! you GOT it! Congratulations!");
}    

  


// 
// P13_1Dollars
// Write a Program that asks how many Dollars the user wants. Then, the program proceeds to printing that many Dollar Symbols.
// 

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

string dollars = Console.ReadLine();
int dollarSigns;
while (!int.TryParse(dollars, out dollarSigns))

    Console.WriteLine("Write a valid number please!");
    dollars = Console.ReadLine();

// 
// P13_2Triangle
// Write a program that prints an ASCII Triangle as big as the user desires. Use goto efficiently to write as little code as necessary.
// 

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

// 
// P13_3Pattern
// Write a program that prints the following pretty ASCII pattern of the size that the user desires. Use goto efficiently to write as little code as necessary.
// 

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");