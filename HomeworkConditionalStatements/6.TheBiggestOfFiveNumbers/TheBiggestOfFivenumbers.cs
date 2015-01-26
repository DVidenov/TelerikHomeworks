//Write a program that finds the biggest of five numbers by using only five if statements.
using System;
class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number d: ");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number e: ");
        double e = double.Parse(Console.ReadLine());
        double biggestAB;
        double biggestCD;
        double biggest;

        if (a > b)
        {
            biggestAB = a;
        }
        else
        {
            biggestAB = b;
        }
        if (c > b)
        {
            biggestCD = c;
        }
        else
        {
            biggestCD = d;
        }
        if (biggestAB > biggestCD)
        {
            biggest = biggestAB;
        }
        else 
        {
            biggest = biggestCD;
        }
        if (biggest>e)
        {
            Console.WriteLine("Biggest number is: {0}",biggest);
        }
        else
        {
            biggest = e;
        }
        Console.WriteLine("Biggest number is: {0}",biggest);
    }
}