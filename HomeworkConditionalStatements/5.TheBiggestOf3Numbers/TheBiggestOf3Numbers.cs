//Write a program that finds the biggest of three numbers.
using System;
class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a < b && b < c && a < c)
        {
            Console.WriteLine(c);
        }
        else if (a > b && b > c && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && a > c && b > c)
        {
            Console.WriteLine(b);
        }
        else if (a > b && c > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > a && a < c && c < b)
        {
            Console.WriteLine(b);
        }
        else if (c > b && a > b && c > a)
            Console.WriteLine(c);
    }
}