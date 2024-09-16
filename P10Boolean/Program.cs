// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your age?");

string Question = Console.ReadLine();

float Answer = float.Parse(Question);

float decimalNumber = Answer;
    
int Age = (int) decimalNumber;

Console.WriteLine("Your age is : " + Age);
bool isChild = Age < 13;
 if (isChild)
  Console.WriteLine("Your are a child");
      else Console.WriteLine("Your are not a child");

bool isTeen = Age > 12 && Age < 20;
if (isTeen)
    Console.WriteLine("Your are a Teen");
else Console.WriteLine("Your are not a Teen");

bool isAdult = Age > 19;
if (isAdult)
    Console.WriteLine("Your are a Adult");
else Console.WriteLine("Your are not a Adult");

bool isOld = Age > 60;
if (isOld)
    Console.WriteLine("Bitch You OLD!");
else Console.WriteLine("Your are not old mate!");

bool isDEAD = Age > 120;
if (isDEAD)
    Console.WriteLine("How arent you DEAD yet O_o");
else Console.WriteLine("Your are not THAT old Yet!");



/*
Console.WriteLine("Enter Your Age:");

string Age = Console.ReadLine();

bool isChild = Age < 13;
bool isTeen = Age > 19 && Age < 13;
bool isAdult = Age > 19;

Console.WriteLine("You age is: " + Age);

bool isChild = true; Console.WriteLine("You are a child: True"); 
bool isChild = false; Console.WriteLine("You are a child: False"); 

bool isTeen = true; Console.WriteLine("You are a teenager: True"); 
bool isTeen = false; Console.WriteLine("You are a teenager: False"); 

bool isAdult = true; Console.WriteLine("You are an adult: True"); 
bool isAdult = false;Console.WriteLine("You are an adult: False"); 
*/


/*
Ask the user for his age. Save it to a variable named age
First, do a few age-checks:
Save to a bool-variable named isChild, whether the age is between 0 and 12
Save to a bool-variable named isTeenager, whether the age is between 13 and 19
Save to a bool-variable named isAdult, whether the age is greater 19
Then, print them all to the console like this:
You are a child: True etc. (see sample below)
*/