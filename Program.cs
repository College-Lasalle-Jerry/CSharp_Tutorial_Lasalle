// Single Line Comment




// Variables and Data Types
// int, double, boolean(true or false), String (This is used to display Messages)

// ctrl + k + C to comment multiple lines at once.
// ctrl + k + u to uncomment multiple lines at once.
// ctrl + s is to save the file

/*
 * This is how we declare variables
 */
/**
* This is a Multiline Comments.
*/

/*
 * Variable Decalartion Rules
 * 1. A Variable name should start with an _ or a string (_name, name, _age, age)
 * 2. No starting with a number
 * 3. No space between words
 * 4. No special characters apart from _ (Underscore)
 * 5. A variable cannot be named after a reserved keyword
 */

int number = 120;
double num = 120;
bool isnum = false;
string str = "hello this is jerry here!";

// Print the result to console
Console.WriteLine("The int number is " + number);
Console.WriteLine("The number is " + num);
Console.WriteLine("The Boolean isNum is " + isnum);
Console.WriteLine("The String is " + str);

// Find the datatype of the variable used
Console.WriteLine("The datatype of number is " + number.GetType());
Console.WriteLine("The datatype of num is " + num.GetType());
Console.WriteLine("The datatype of isnum is " + isnum.GetType());
Console.WriteLine("The datatype of str is " + str.GetType());


// Console Input
Console.WriteLine("enter your name: ");    
string name = Console.ReadLine();
Console.WriteLine("hello "+name+"!");

Console.WriteLine("Enter your first number");
string num1 = Console.ReadLine();
Console.WriteLine("Datatype of num1 "+ num1.GetType());

Console.WriteLine("Enter your second number");
string num2 = Console.ReadLine();
Console.WriteLine("Datatype of num2 " + num2.GetType());

Console.WriteLine("Sum of two numbers "+num1 + num2);    

// convert to integer
int n1 = int.Parse(num1);
int n2 = int.Parse(num2);

// Display the new Datatypes
Console.WriteLine("Datatype of n1 " + n1.GetType());
Console.WriteLine("Datatype of n2 " + n2.GetType());

// Add two Numbers
Console.WriteLine("Sum of Two Numbers: " + (n1+n2));



