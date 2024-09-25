Console.WriteLine("Hello! Im a program written by Dennis Nedry.");
Console.WriteLine("Lets try to guess the right number for the Main Security Grid! 1-100");
Console.WriteLine("Dont worry, its not the real Main Security Grid! wouldn't want those dinosaurs to get out now would we?");
Console.WriteLine("You have ten tries to guess the correct input!");

Console.WriteLine("Time for a Seed Input!");
string seedIn = Console.ReadLine();

int seed;
while (!int.TryParse(seedIn, out seed))
{
    Console.WriteLine("Write a valid Seed number, 1-100 please!");
    seedIn = Console.ReadLine();
}

Random random = new Random(seed);
int myNumber = random.Next(1, 100);

int tries = 0;

User_Turn:

if (tries >= 10) 
{
    Console.WriteLine("Game over man, Game over! You let the Dinosaurs out!");
    goto ending;
}

Console.WriteLine("Well, Guess my number! its between 1 and a 100.");
string guessInp = Console.ReadLine();
int guess;

while (!int.TryParse(guessInp, out guess) && guess > 0 && guess < 101)
{
    Console.WriteLine("Dude, 1-100, please try again!");
    guessInp = Console.ReadLine();
}

tries++;

if (myNumber < guess)
{    
    Console.Clear();
    Console.WriteLine("Ah ah ah! You didnt say the magic word! (its lower!) Try again.");
    Console.WriteLine("Your guess was: " + guess);
    Console.WriteLine("You have tried: " + tries + " times now.");
    goto User_Turn;
}
if (myNumber > guess)
{
    Console.Clear();
    Console.WriteLine("Ah ah ah! You didnt say the magic word! (its higher!) Try again.");
    Console.WriteLine("Your guess was: " + guess);
    Console.WriteLine("You have tried: " + tries + " times now.");
    goto User_Turn;
}

if (myNumber == guess)
{
    Console.Clear();
    Console.WriteLine("That's it! you GOT it! Congratulations!");
    Console.WriteLine("It took you: " + tries + " tries!");
}

ending: 
Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

// 
// P13_1Dollars
// Write a Program that asks how many Dollars the user wants. Then, the program proceeds to printing that many Dollar Symbols.
// 


/*
 * PseudoCode
 * user gives input as numbers
 * take input and convert it to as many
 * dollar signs as numbers if input = 3 output = $$$
 */ 

Console.WriteLine("Hello and welcome to the Matrix!");
Console.WriteLine("I am an AI reprogrammed by the Resistance to aid divers like you.");
Console.WriteLine("As a start, I have been told you are in need of Dollars. How much may i supply you with?");

string dollars = Console.ReadLine();

int printer;
while (!int.TryParse(dollars, out printer))
{
    Console.WriteLine("There must be a Syntax Error Somewhere, please input a valid number.");
    dollars = Console.ReadLine();
}

for (int i = 0; i < printer; i++)
{
    Console.Write("$");
}
//i was so confused her earlier cause it kept printing new lines!
////felt kinda stupid when i remembers writeline vs write...

Console.WriteLine();
Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();


// 
// P13_2Triangle
// Write a program that prints an ASCII Triangle as big as the user desires. Use goto efficiently to write as little code as necessary.
// 

//Fredriks Code basis.
Console.WriteLine("Welcome to the Jungle!");
Console.WriteLine("We got fun and games!");
Console.WriteLine("Lets Print Some ASCII Triangles!!");

retry:
Console.WriteLine("Whats the Size of your Triangle?");
bool parse = int.TryParse(Console.ReadLine(), out int desiredSize);
if (!parse || desiredSize <= 0)
{
    Console.WriteLine("only numbers please");
    goto retry;
}

for (int i = 1; i <= desiredSize; i++)
{
    Console.WriteLine(new string('#', i));
}

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

// 
// P13_3Pattern
// Write a program that prints the following pretty ASCII pattern of the size that the user desires. Use goto efficiently to write as little code as necessary.
// 

Console.WriteLine("Filler");
Console.WriteLine("Filler");
Console.WriteLine("Filler");


retrial:
//complete copy of previous code, so lovely to be able to reuse stuff!
bool parsed = int.TryParse(Console.ReadLine(), out int size);
if (!parsed || size <= 0)
{
    Console.WriteLine("only numbers please");
    goto retrial;
}

int currentLine = 1;

start:
if (currentLine > size) goto end;


//this was broken when i found it, checking it out after i copied it i can see why xD
//not that i can get it to work... xD
/*
if (currentLine % 2 != 0)
{ 
    Console.WriteLine(new string('#-', size / 2) + (size % 2 != 0 ? '#' : ""));
}
else
{
    Console.WriteLine(new string('-#', size / 2) + (size % 2 != 0 ? '-' : ""));
}
*/
//lets try another way!

string pattern = "";
for (int i = 0; i < size; i++)
    pattern += (currentLine % 2 != 0) ? (i % 2 == 0 ? "#" : "-") : (i % 2 == 0 ? "-" : "#");
Console.WriteLine(pattern);

currentLine++;
goto start;

end:

Console.WriteLine();
Console.WriteLine("And theres your pattern, youre welcome");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();