// See https://aka.ms/new-console-template for more information


//1.Write a C# program to print Hello and your name in the same line.
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello George");

//2.Write a C# program to print the sum of two numbers and the division
//of those two numbers.
float number1 = 6;
float number2 = 4;

float sum = number1 + number2;
float division = number1/number2;

Console.WriteLine("The sum is " + sum + " and the division is " + division);

//3.Write a C# program to print the result of the specified operations:

Console.WriteLine(-1 + (5*6));
Console.WriteLine(38 + 5 % 7);
Console.WriteLine(14 + ((-3*6)/7));
Console.WriteLine(2 + ((13/6) * 6) + Math.Sqrt(7) );
Console.WriteLine((Math.Pow(6,2) + Math.Pow(5,7)) / (9%4));

//4. Write a C# program that assigns an age (number) (for example 20) and
//a gender(string) (for example female) and displays something like:
//"You are female and look younger than 20." 

int age = 20;
string gender = "female";

Console.WriteLine("You are " + gender + " and you look younger than " + age);

//5.Write a C# program that takes an integer representing seconds (for
//example 45678) and converts it to :

int seconds = 31536000;

int minutes = seconds / 60;
int hours = minutes/ 60;
int days = hours/ 24;
int years = days / 365;

//6.Rewrite Program #5 using .Net Libraries. 


TimeSpan t = TimeSpan.FromSeconds(84600);

int minutes2 = t.Minutes;
int hours2 = t.Hours;
int days2 = t.Days;
// TimeSpan method is not supporting years solution.

//7.Write a C# program to convert from celsius degrees to Kelvin and
//Fahrenheit

int celsius = 40;

int kelvin = celsius + 273;
int fahrenheit = celsius * 18 / 10 + 32;

Console.ReadLine();


