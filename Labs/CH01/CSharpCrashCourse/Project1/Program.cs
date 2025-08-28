// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//byte - 8 bit 0 -255
//sbyte -127 through 128
//short - 16 bits
//int 32 bits
//uint 0 - 4billion
//long 64 bits
//char

//Data types can be marked as nullable
//Signed or Unsigned

//floats 32 bits
//doubles 64 bits
//decimal 128 bits

//booleans

//REFERANCE or OBJECT
//String
//Objects
//Arrays
//Interfaces
//Dynamic
//Pointer

Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

//Ask the user for their age, append their age to the WriteLine Statement in line 34
Console.WriteLine("Enter your age:");
int userAge = Convert.ToInt32(Console.ReadLine());

//Hello Bob you are 43 years old.
Console.WriteLine($"Hello {name}, You are {userAge} years old");