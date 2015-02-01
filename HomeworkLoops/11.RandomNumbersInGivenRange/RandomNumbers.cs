//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
using System;
class RandomNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter min number:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter max number:");
        int max = int.Parse(Console.ReadLine());
        Random first = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}",first.Next(min,max+1));
        }
        Console.WriteLine();
    }
}