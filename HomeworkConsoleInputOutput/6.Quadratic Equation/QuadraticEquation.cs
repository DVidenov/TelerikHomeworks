//Write a program that reads the coefficients a, b and c 
//of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter aX^2: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bX: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter c: ");
        int c = int.Parse(Console.ReadLine());
        {
            double d = (((b) * (b)) - (4 * a * (c))) / (2 * a);
            double e = (b + (System.Math.Sqrt(d))) / (2 * a);
            double f = (b - (System.Math.Sqrt(d))) / (2 * a);
            Console.WriteLine("X1={0}", Math.Round(e, 2));
            Console.WriteLine("X2={0}", Math.Round(f, 2));
        }
    }
}