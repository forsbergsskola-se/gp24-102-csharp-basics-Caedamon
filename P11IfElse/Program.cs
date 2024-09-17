
//
//  PART ONE
//



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



/*pseudo Code
If Q2 is greater than age = output: your age is greater than your number
If q2 is lesser than age = output: your age is lesser than your number
if Q2 is equal to age = output: Your age is the same as your number
*/

Console.WriteLine("Give me a Number!");

string Question2 = Console.ReadLine();
while (!int.TryParse(Question2, out int result))
    {
        Console.WriteLine("Write a number please!");
        Question = Console.ReadLine();
    }

float Answer2 = float.Parse(Question2);
float decimalNumber2 = Answer2;
int Number2 = (int) decimalNumber2;
Console.WriteLine("Your age is: " + Age + ", and your number is: " + Number2);

bool isGreater = Age > Number2;
if (isGreater) 
//greater-Output
    Console.WriteLine("The number you put in: " + Number2 + " is Lower than your age.");
    else if (Age < Number2) Console.WriteLine("The number you put in: " + Number2 + " is larger than your age.");
    else Console.WriteLine("The number you put in: " + Number2 + "the same as your age.");

    if (Number2 % 2 == 0)
        Console.WriteLine("It is an even number");
    else
        Console.WriteLine("It is an odd number");

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();

//
//  PART TWO - P11_1Grades
//        

Console.WriteLine("Please hold while an AI gets in touch with you...");
Console.WriteLine("Hello! I am Hal9000, I am currently in the process of grading your latest test.");
Console.WriteLine("Please, Tell me the score you got on your last test (0-100)");

string Grade = Console.ReadLine();
while (!int.TryParse(Grade, out int result))
    {
        Console.WriteLine("Write a number between 0 and 100 please!");
        Question = Console.ReadLine();
    }
float Answer3 = float.Parse(Grade);
float decimalNumber3 = Answer3;
int Grade2 = (int) decimalNumber3;

if (Grade2 > 89 && Grade2 < 101) 
    Console.WriteLine("Your Grade was: " + Grade + " That, is a A! Congratulations!");
else if (Grade2 > 79 && Grade2 < 90) 
    Console.WriteLine("Your Grade was: " + Grade + " That, is a B! Very Good!");
else if (Grade2 > 69 && Grade2 < 80) 
    Console.WriteLine("Your Grade was: " + Grade + " That, is a C! I guess thats good enough");
else if (Grade2 > 59 && Grade2 < 60) 
    Console.WriteLine("Your Grade was: " + Grade + " That, is a D... really? You could have done better you know");    
else 
    Console.WriteLine("Your Grade was: " + Grade + " That's... That's an F... Just what do you think you are doing, Dave?");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
//  PART THREE - P11_2MinMax
//   

Console.WriteLine("Please hold while an AI gets in touch with you...");
Console.WriteLine("I Am WOPR! An advanced War Operation Plan Response supercomputer"); 
Console.WriteLine("You have been tasked with giving me coordinates. I will need 3 coordinate-numbers from you."); 
Console.WriteLine("Enter the first number (1-999): ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number(1-999): ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number(1-999): ");
int num3 = Convert.ToInt32(Console.ReadLine());

int min, max;

if (num1 <= num2 && num1 <= num3)
    min = num1;
else if (num2 <= num1 && num2 <= num3)
    min = num2;
else
    min = num3;

if (num1 >= num2 && num1 >= num3)
    max = num1;
else if (num2 >= num1 && num2 >= num3)
    max = num2;
else
    max = num3;

Console.WriteLine($"The lowest Coordinate is : {min}, Largest is: {max}");
Console.WriteLine("Thank you for your assistance! Nukes will be dropped at the following coordinates: " + num1 + "," + num2 + "," +  num3);

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
//  PART FOUR - P11_3Characters
//   











Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
//  PART FIVE - P11_4Calculator
//   P11_5EvenOrOdd


Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();
//
//  PART SIX - P11_5EvenOrOdd
//   