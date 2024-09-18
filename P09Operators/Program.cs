// See https://aka.ms/new-console-template for more information

/*
 https://github.com/marczaku/102-csharp-basics/tree/main/09-operators
 */
// theres to much damn green text in this document D=
//and i seriously need to start every assignment by writing down what i want in pseudo-code... but i keep forgeting

Console.WriteLine("Hello, User!");
Console.WriteLine("Today, we are doing something, Magical!");
Console.WriteLine("We! or well, to be precise, I, your semi 'friendly' Artificial Overlord");
Console.WriteLine("Will be transforming seconds that YOU give me");
Console.WriteLine("Into Days, Hours, Minutes and Seconds!");
Console.WriteLine("So please, Do give me a number of seconds :)");


string number = Console.ReadLine();
int totalSeconds;
while (!int.TryParse(number, out totalSeconds))
{
    Console.WriteLine("Write a valid number please!");
    number = Console.ReadLine();
}
//honestly, i still cant figure out why this works xD
// im way to used to using Gdot i think O_o

/*
btw totalSeconds = https://learn.microsoft.com/en-us/dotnet/api/system.timespan.totalseconds?view=net-8.0
kinda wish that was in the help document on upg-9 =P
Im pretty sure that what you *want* us to do in this assignment is using division and not what im doing below.
i might be overthinking things like mad o_O
Pseudo Code for what i THINK you acctually want, is something like
Int = gief [seconds]
Divide seconds by 60 to get [mins]
equalise [mins] to lose the [eccess_seconds]

Divide mins by 60 to get [hours]
equalise [hours] to lose the [eccess_mins]

Divide hours by 24 to get [days]
equalise [days] to lose the [eccess_hours]

print [days],[hours],[mins],[seconds]

*/

int days = totalSeconds / (24 * 3600); 
totalSeconds %= 24 * 3600;             

int hours = totalSeconds / 3600;      
totalSeconds %= 3600;                

int minutes = totalSeconds / 60;     
int seconds = totalSeconds % 60;     


Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");
Console.WriteLine($"{days}.{hours:D2}:{minutes:D2}:{seconds:D2}");

/* double totalDays = days + (hours / 24.0) + (minutes / 1440.0) + (seconds / 86400.0);
 i tried both of this and the one below, and i prefer days/mins/s but... im not sure wich is right xD
*/

double totalDays = days + (seconds / 86400.0) + (minutes / 1440.0) + (hours / 24.0);
Console.WriteLine($"In total, that's {totalDays} Days."); 
//Seconds per day, minuts per day, hours per day

//gona have to figure out how to round that out. i think we did it in one of the previous assignments =/
//But i cant figure out which one (i also need to learn to stop typing witch when i mean which... damn dyslexia...)5
//Anyways! by rounding out i mean so that theres only x.xx days, and not potentially x.xxxxxxxxxxxxxx days...

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
// P09_01SpeedConverter
//
Console.WriteLine("Hello again, User!");
Console.WriteLine("Today, we are doing something else!");
Console.WriteLine("We  will today implement a way where you input km/h and i will display it in m/s.");
Console.WriteLine("Its hard, Its painfull, But we've got to!");
Console.WriteLine("Now, you got a speeding ticket didnt you... Tell me how fast you where going?");

string kmH = Console.ReadLine();
int seconds while (!int.TryParse(kmH, out seconds))
{
    Console.WriteLine("Write KM/H numbers please! nothing else");
    kmH = Console.ReadLine();
}

double kmH = double.Parse(Console.ReadLine());
double seconds = kmH / 3.6;
//lawd im not a fan of math!

Console.WriteLine($"{kmH} km/h is equal to {seconds} m/s");




















/* --- all this is Fredriks Recap comment in the chat... this way i dont have to switch window if i wanna check it all the time xD
 
// Slide 9 - Operator Recap:

// doing any mathematical operation is quite easy, and works the same way as you'd expect any mathematical expression outside of code
// addition can be done this way:

int one = 1;
int two = 2;
int three = one + two; // can be done with two variables
int threeAgain = one + 2; // or using a variable plus a number directly.
int threeAgain2 = 1 + 2; // or two numbers directly.
one += two; // adds one together with two for the sum of 3

// Equally multiplication, subtraction or division are possible the same way:

int four = 4;
int fourTimesTwo = four * 2;
float fourDividedByThree = four / 3f; // watch out, dividing two whole numbers can result in loss of precision, specify one as float or double
int negativeOne = one - two;

// Modulo operator (the percent sign %) is used to get the remainder of a division
int remainderOf = 10 % 3; // equals 1 as 3*3+1 = 10
// It can also be used to determine if a number is odd or even by using number % 2
int remainderOfModulo = 9 % 2;
bool isOdd = remainderOfModulo > 0;

if (isOdd) {
    Console.WriteLine("The number is odd!");
} else if (!isOdd) {
    Console.WriteLine("The number is even!");
}

// Some smart operators can help you write less code like the pre and post increment / decrement operators.
// You use them as follows:
int nine = 9;
Console.WriteLine($"Incrementing AFTER I read the value of Nine: {nine++}");
Console.WriteLine($"Reading the value of Nine: {nine}");
Console.WriteLine($"Decrementing Nine BEFORE reading it: {--nine}");
 */