﻿//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.
using System;
class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        if (0 <= a && a <= 500)
        {
            Console.WriteLine("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            double c = double.Parse(Console.ReadLine());
            string bita = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("|{0,-10:X}|{1}|{2,10:N2}|{3,-10:0.000}|", a, b, c, bita);
        }
        else
        {
            Console.WriteLine("No correct number a");
        }
    }
}
