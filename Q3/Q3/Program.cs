



//write a program to swap two numbers without using a temp variable in C#

int a = 20;
int b = 15;

Console.WriteLine($"Before swapping: a = {a}, b = {b}");

 a = a + b;
 b = a - b;
 a = a - b;

Console.WriteLine($"After swapping: a = {a}, b = {b}"); 
