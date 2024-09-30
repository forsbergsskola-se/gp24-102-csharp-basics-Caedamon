// See https://aka.ms/new-console-template for more information


/*

Console.WriteLine("Enter a number with 1 Decimal:");
string number = Console.ReadLine();
Console.WriteLine(number);
float numberFloat = float.Parse(number);
int number = Convert.ToInt32(numberFloat);

Console.WriteLine(number);
*/

//following stolen by Niko... but it works!
Console.WriteLine("Enter a number with 1 Decimal:");
string question = Console.ReadLine();
Console.WriteLine(question);
float answer = float.Parse(question);
float decimalNumber = answer;
int number = (int) decimalNumber;
Console.WriteLine(number);




/*
Create a Console Project named P8Conversion How To?
Ask the user for a Number and assign the result to a variable.
Convert the variable to Type float.
Print the float to the Console.
Convert the double number to type int.
Print the int to the console.
Convert the original string to type int.
What happens? (Hint: You will see an Invalid Format Exception
*/