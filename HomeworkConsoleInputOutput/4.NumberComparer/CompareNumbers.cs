//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
using System;
class CompareNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        double greaterNum = Math.Max(firstNum, secondNum);
        {
            Console.WriteLine("The bigger number is: {0}", greaterNum);
        }
    }
}

