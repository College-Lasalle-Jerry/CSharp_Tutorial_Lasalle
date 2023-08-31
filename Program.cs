// Single Line Comment




// Variables and Data Types
// int, double, boolean(true or false), String (This is used to display Messages)

// ctrl + k + C to comment multiple lines at once.
// ctrl + k + u to uncomment multiple lines at once.

/*
 * This is how we declare variables
 */
using System.Runtime.InteropServices;
/**
* This is a Multiline Comments.
*/
int number = 120;
double num = 120;
bool isnum = false;
string str = "hello this is jerry here!";

// Print the result to console
Console.WriteLine("The int number is "+number);
Console.WriteLine("The number is "+num);
Console.WriteLine("The Boolean isNum is " + isnum);
Console.WriteLine("The String is " + str);

// Find the datatype of the variable used
Console.WriteLine("The datatype of number is "+ number.GetType());
Console.WriteLine("The datatype of num is " + num.GetType());
Console.WriteLine("The datatype of isnum is " + isnum.GetType());
Console.WriteLine("The datatype of str is " +str.GetType());

