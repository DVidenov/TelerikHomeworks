﻿using System;
class Calculate
{
    static void Main()
    {
        Console.WriteLine("Enter number n: ");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number x: ");
        double x = double.Parse(Console.ReadLine());

        double sum = 1;
        double fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            sum += (fact / (Math.Pow(x, i)));

        }
        Console.WriteLine("{0:F5}",sum);
    }
}