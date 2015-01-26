//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
using System;
class Sort3NumbersWithNestedLfs
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter secon number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double c = double.Parse(Console.ReadLine());
        if (a < b && b < c)
        {
            Console.WriteLine("result: {0} {1} {2}", c, b, a);
        }
        else if (b < a && a < c)
        {
            Console.WriteLine("result: {0} {1} {2}", c, a, b);
        }
        else if (c < a && a < b)
        {
            Console.WriteLine("result: {0} {1} {2}", b, a, c);
        }
        else if (c < b && b < a)
        {
            Console.WriteLine("result: {0} {1} {2}", a, b, c);
        }
        else if (b < c && c < a)
        {
            Console.WriteLine("result: {0} {1} {2}", a, c, b);
        }
    }
}