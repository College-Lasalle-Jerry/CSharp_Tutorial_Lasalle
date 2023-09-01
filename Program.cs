// Single Line Comment
/**
* This is a Multiline Comments.
*/
// Variables and Data Types
// int, double, boolean(true or false), String (This is used to display Messages)

// ctrl + k + C to comment multiple lines at once.
// ctrl + k + u to uncomment multiple lines at once.
// ctrl + s is to save the file

/*
 * This is how we declare variables
 */


/*
 * Variable Decalartion Rules
 * 1. A Variable name should start with an _ or a string (_name, name, _age, age)
 * 2. No starting with a number 
 * 3. No space between words (your_age)
 * 4. No special characters apart from _ (Underscore)
 * 5. A variable cannot be named after a reserved keyword
 */

int number = 120;
double num = 120.258;
bool isnum = false;
string str = "hello this is jerry here!";

//// Print the result to console
Console.WriteLine("The int number is " + number);
Console.WriteLine("The number is " + num);
Console.WriteLine("The Boolean isNum is " + isnum);
Console.WriteLine("The String is " + str);
Console.WriteLine($"The String is {str}"); // String Interpolation    

//// Find the datatype of the variable used
Console.WriteLine($"The datatype of number is {number.GetType()}");
Console.WriteLine("The datatype of num is " + num.GetType());
Console.WriteLine("The datatype of isnum is " + isnum.GetType());
Console.WriteLine("The datatype of str is " + str.GetType());


//// Console Input
Console.WriteLine("enter your name: ");    
string name = Console.ReadLine();
Console.WriteLine($"Hi {name}!");

Console.WriteLine("Enter your first number");
string num1 = Console.ReadLine();
Console.WriteLine("Datatype of num1 "+ num1.GetType());

Console.WriteLine("Enter your second number");
string num2 = Console.ReadLine();
Console.WriteLine("Datatype of num2 " + num2.GetType());

Console.WriteLine("Sum of two numbers "+num1 + num2);    

//// convert to integer
Console.WriteLine("n1 and n2 Datatypes - Convert from String to int");    
int n1 = int.Parse(num1);
int n2 = int.Parse(num2);

//// Display the new Datatypes
Console.WriteLine("datatype of n1 " + n1.GetType());
Console.WriteLine("datatype of n2 " + n2.GetType());

//// Add two Numbers
Console.WriteLine("Sum of Two Numbers: " + (n1 + n2));


// Practice 1
// integer
int number1 = 10, number2 = 20;

// double
double number3 = 12, number4 = 13;

// boolean
bool isnum = true, isnum1 = false;

// String
string str1 = "hello", str2 = "bye bye";

// Print all the variables
Console.WriteLine($"The datatype of number1 is {number1.GetType()}, and the value it contains is {number1} ");
Console.WriteLine($"The datatype of number2 is {number2.GetType()}, and the value it contains is {number2} ");
Console.WriteLine($"The datatype of number3 is {number3.GetType()}, and the value it contains is {number3} ");
Console.WriteLine($"The datatype of number4 is {number4.GetType()}, and the value it contains is {number4} ");

Console.WriteLine($"The datatype of isnum is {isnum.GetType()}, and the value it contains is {isnum} ");
Console.WriteLine($"The datatype of isnum1 is {isnum1.GetType()}, and the value it contains is {isnum1} ");

Console.WriteLine($"The datatype of str1 is {str1.GetType()}, and the value it contains : {str1} ");
Console.WriteLine($"The datatype of str2 is {str2.GetType()}, and the value it contains : {str2} ");


// Console Input
Console.WriteLine("Enter your name");
string name = Console.ReadLine();

Console.WriteLine("Enter your age");
string age = Console.ReadLine();
//int convertedAge = Convert.ToInt32( age );
//int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Hello {name}, you are {age} yrs. Old. ");


// Conversion or in techincal terms it is as Type Casting.
// implicit and explicit

// declare an integer
int toConvert = 99;


double convertToDouble = toConvert; // Implicit TypeCasting
double convertToDouble2 = (double)toConvert; // Explicit TypeCasting


Console.WriteLine($"convertToDouble Datatype: {convertToDouble.GetType()}");
Console.WriteLine($"convertToDouble2 Datatype: {convertToDouble2.GetType()}");

// To convert to a string
String str12 = toConvert.ToString();
Console.WriteLine("STR Datatype " + str12.GetType());

string convertDouble1 = convertToDouble.ToString();
Console.WriteLine("ConvertDouble1 Datatype " + convertDouble1.GetType());

double numberToInt = 123.33;
Console.WriteLine(numberToInt);
int numberToInt1 = (int)numberToInt;
Console.WriteLine(numberToInt1);


