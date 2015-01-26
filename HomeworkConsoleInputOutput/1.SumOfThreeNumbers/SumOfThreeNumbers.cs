//Write a program that reads 3 real numbers from the console and prints their sum.
using System;
class SumOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        double d = (double)(a + b + c);
        Console.WriteLine("The number is: " + d);
    }
}