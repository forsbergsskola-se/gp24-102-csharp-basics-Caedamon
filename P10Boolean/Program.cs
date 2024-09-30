Console.WriteLine("What is your age?");

string Question = Console.ReadLine();
while (!int.TryParse(Question, out int result))
{
    Console.WriteLine("Write a number please!");
    Question = Console.ReadLine();
}

float Answer = float.Parse(Question);

float decimalNumber = Answer;
int Age = (int) decimalNumber;
//Converstion Code copied!

Console.WriteLine("Your age is : " + Age);
//Child
bool isChild = Age < 13;
if (isChild) 
//Child-Output
    Console.WriteLine("Is a child Indeed!");
else Console.WriteLine("Is not a child!");
//Teen
bool isTeen = Age > 12 && Age < 20;
if (isTeen) 
//Teen-Ouput
    Console.WriteLine("Is a Teen Indeed!");
else Console.WriteLine("Is not a Teen!");
//Adult
bool isAdult = Age >19;
if (isAdult) 
//Adult-Output
    Console.WriteLine("Is a Adult Indeed!");
else Console.WriteLine("Is not a Adult");

bool isOld = Age > 60;
if (isOld)
    Console.WriteLine("Bitch You OLD!");
else Console.WriteLine("Your are not old mate!");

bool isDead = Age > 120;
if (isDead)
    Console.WriteLine("How arent you DEAD yet");
else Console.WriteLine("Your are not THAT old Yet!");