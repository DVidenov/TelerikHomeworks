//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;
using System.Linq;
class SumOfFiceNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers separated by space: ");
        double[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => double.Parse(x))
            .ToArray();

        Console.WriteLine("The sum if the numbers if {0:F2}.", numbers.Sum());
    }
}