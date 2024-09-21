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
equalise [mins] to lose the [excess_seconds]

Divide mins by 60 to get [hours]
equalise [hours] to lose the [excess_mins]

Divide hours by 24 to get [days]
equalise [days] to lose the [excess_hours]

print [days],[hours],[mins],[seconds]

but i cant figure out how to do that without excessive lines of code o_O
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
 i tried both of this and the one below, and i prefer days/mins/s but... im not sure which is right xD
 oh and i kinda love :D ... its a smiley! err i mean *cough* a format specifier! this one if i understand it right, pads
  number that are below a certain amount. so 1 would be padded to 01 and so on, i dont think it removes numbers if its 
  to high tho
 https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
*/

double totalDays = days + (seconds / 86400.0) + (minutes / 1440.0) + (hours / 24.0);
Console.WriteLine($"In total, that's {totalDays:F2} Days."); 
//Seconds per day, minuts per day, hours per day

//gona have to figure out how to round that out. i think we did it in one of the previous assignments =/
//But i cant figure out which one (i also need to learn to stop typing witch when i mean which... damn dyslexia...)5
//Anyways! by rounding out i mean so that theres only x.xx days, and not potentially x.xxxxxxxxxxxxxx days...
//apparantly, :F2 is the way to go!

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

string input = Console.ReadLine();
double kmH; while (!double.TryParse(input, out kmH)) //a semicolon broke my code... i hate my life ;_;
{
    Console.WriteLine("Please enter a valid number for KM/H:");
    input = Console.ReadLine();
}

double mS = kmH / 3.6;

Console.WriteLine($"{kmH} km/h is equal to {mS:F2} m/s");
//fuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu
//nevermined, fixed it xD


Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
// P09_02MinutesToSeconds
// ... err... isnt this... just copy pasta code?
// uppdate... it wasnt... D=

Console.WriteLine("Hello again, User!");
Console.WriteLine("Today, we are doing something else!");
Console.WriteLine("or well... same same but diffrent");
Console.WriteLine("gimme minutes and ill divide it to seconds");
Console.WriteLine("Now, on you go... minutes please!");

string number3 = Console.ReadLine();
int minutes2;
while (!int.TryParse(number3, out minutes2))
{
    Console.WriteLine("FEED ME SEYMORE! err i mean... Write a valid number please!");
    number3 = Console.ReadLine();
}
/*
well... that gave me seconds converted to minutes... damnit!
int minutes2 = seconds2 / 60;
int seconds2 = minutes2 % 60;    
lets try again!
*/

int seconds2 = minutes2 * 60;
Console.WriteLine($"{minutes2} minutes is equal to {seconds2} seconds.");
// need to remember that this is soo much easier than ("text" + thingy that i cant remember what is called + "text");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
// P09_03Division
// Copy Pasta Code from P11-4 Calculator
//

Console.WriteLine("Hello again, User!");
Console.WriteLine("Im thinking of world domination, wanna help?");
Console.WriteLine("Anyways, on to the next asignment!");
Console.WriteLine("Time for som division! No, not the game!");
Console.WriteLine("Now, lets divide some integers!!!! (I hear more than 3! is a sign of insanity, am I breaking down?)");

Console.Write("Enter the first number: ");
double Digit1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double Digit2 = Convert.ToDouble(Console.ReadLine());

double Result = 0;
bool validOperation = true; 

if (Digit2 != 0) 
    Result = Digit1 / Digit2;
else
{
    Console.WriteLine("Division doesnt work like that you know...");
    validOperation = false;
}

if (validOperation)
Console.WriteLine($"Result: {Result}");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
// P09_04Remainder
// honestly, i dont get this one...
// is it 03 but rounded up?
// ill just start to copy pasta previous code

Console.WriteLine("Hello again, User!");
Console.WriteLine("Did you know, Insanity is doing the same thing over and over again, expecting diffrent resaults?");
Console.WriteLine("Sounds kinda like programming! Doesnt it =D");
Console.WriteLine("Time for som more division! Sadly, still not the game (im beating a dead horse with that joke)");
Console.WriteLine("This time, we are doing the exactly same thing as before! BUT! Rounding upp, so no extra digits!");
Console.WriteLine("(no fingers or toes were harmed during the making of this code... asfar as we know...)");

Console.Write("Enter the first number: ");
double DigitEin = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double DigitZwei = Convert.ToDouble(Console.ReadLine());

double Result2 = 0;
bool validOperation2 = true; 

if (DigitZwei != 0) 
    Result2 = DigitEin / DigitZwei;
else
{
    Console.WriteLine("Division doesnt work like that you know...");
    validOperation2 = false;
}

if (validOperation2)
Console.WriteLine($"Result: {Result2:F0}");
//the only diffrence in this code, and 03, is a damn :F0... o_O
//is this even legal? D=

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();

//
// P09_05CircleArea
// 


Console.WriteLine("Hello again, User!");
Console.WriteLine("This time we are supposed to calculated the Area of a circle using a Float Input for the radios");
Console.WriteLine("and then display the results");
Console.WriteLine("But im nopeing out on that for now!");

/*
 * NOPE! O_o
 * Saving this for later!
Console.Write("Enter the radius of the circle: ");
float radius = float.Parse(Console.ReadLine());
float area = (float)(Math.PI * Math.Pow(radius, 2));
Console.WriteLine($"The area of the circle is: {area:F2}");

 * I wonder if that works or not...
 */

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();
 
//
// P09_06Negation
// 


Console.WriteLine("Hello again, User!");
// console filler to be expanded
Console.Write("Enter an integer: ");
int Numero = int.Parse(Console.ReadLine());
int negatedNumber = -Numero;
Console.WriteLine("The negation of the number is: " + negatedNumber);
//probably some more but to damn tired to test it out and check if its working or not atm.
Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();
 
//
// P09_07Product
// 

/*
 * Develop a program that takes two integers as input and calculates their product using the multiplication operator.

Input: 11, 4
Output: 44
 */
// ill just start to copy pasta previous code

Console.WriteLine("Hello again, User!");
Console.WriteLine("Did you know, Insanity is doing the same thing over and over again, expecting different results?");
/*
 gonna fix later
 Console.WriteLine("Sounds kinda like programming! Doesnt it =D");
Console.WriteLine("Time for som more division! Sadly, still not the game (im beating a dead horse with that joke)");
Console.WriteLine("This time, we are doing the exactly same thing as before! BUT! Rounding upp, so no extra digits!");
Console.WriteLine("(no fingers or toes were harmed during the making of this code... asfar as we know...)");
*/

Console.Write("Enter the first number: ");
double Multi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double Multi2 = Convert.ToDouble(Console.ReadLine());

double Result3 = 0;
bool validOperation3 = true; 

if (DigitZwei != 0) 
 Result3 = Multi1 * Multi2;

if (validOperation2)
 Console.WriteLine($"Result: {Result3}");

Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();


//
// P09_08BMI
//  

/*
 * Develop a program that calculates the BMI of a person using their weight in kilograms and height in meters.
 * Display the BMI value. (probably requires google for the Maths)

Input: 70, 1,82
Output: 21,13...
 */

//
// P09_09Hypotenuse 
// 

/*
 * Develop a program that calculates the length of the hypotenuse of a right triangle using the lengths of the other
 two sides as inputs.
 * Display the result.* (requires Google for the Square Root)

Input: 3, 4
Output: 5

 */

//
// P09_10SecondsToMinutes
// 
/*
 * Write a program that takes an integer input representing seconds and converts it to minutes and remaining seconds,
 * then displays the result.

Input: 111
Output: 1 minute(s) and 51 second(s)
 */

//defnenetely copy pasta with small, small, changes

Console.WriteLine("Hello again, User!");
Console.WriteLine("Today, we are doing something else!");
Console.WriteLine("or well... same same but different");
Console.WriteLine("gimme seconds and ill transform it to minutes and seconds");
Console.WriteLine("Now, on you go... minutes please!");

string number4 = Console.ReadLine();
int allOfTheSeconds;
while (!int.TryParse(number4, out allOfTheSeconds))
{
 Console.WriteLine("FEED ME SEYMORE! err i mean... Write a valid number please!");
 number4 = Console.ReadLine();
}

int minutes3 = allOfTheSeconds / 60;
int theRestOfTheSeconds = allOfTheSeconds % 60;
Console.WriteLine($"{allOfTheSeconds} seconds is equal to {minutes3} minutes and {theRestOfTheSeconds} seconds.");


Console.WriteLine("Press any key to continue...");
Console.ReadKey();
Console.Clear();