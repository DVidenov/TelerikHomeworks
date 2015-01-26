//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum
using System;
class SumOfnNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (double i = 1; i <= n; i++)
            sum += double.Parse(Console.ReadLine());
        {
            Console.WriteLine("The result is: {0}", sum);
        }
    }
}