//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
using System;
class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number: ");
        int numThree = int.Parse(Console.ReadLine());

        if (numOne < 0 && numTwo > 0 && numThree > 0)
        {
            Console.WriteLine("result: -");
        }
        else if (numOne < 0 && numTwo < 0 && numThree > 0)
        {
            Console.WriteLine("result: +");
        }
        else if (numOne > 0 && numTwo > 0 && numThree > 0)
        {
            Console.WriteLine("result: +");
        }
        else if (numOne >= 0 && numTwo < 0 && numThree > 0)
        {
            Console.WriteLine("result: 0");
        }
        else if (numOne < 0 && numTwo < 0 && numThree < 0) 
        {
            Console.WriteLine("result: -");
        }
    }
}