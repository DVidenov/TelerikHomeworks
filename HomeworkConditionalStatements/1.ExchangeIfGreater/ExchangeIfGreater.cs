//Write an if-statement that takes two double variables a and b and exchanges their values if 
//the first one is greater than the second one. As a result print the values a and b, separated by a space.
using System;
class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        if (secondNum < firstNum)
        {
            Console.WriteLine();
            Console.WriteLine("{0} {1}", firstNum, secondNum);
        }
        else if (firstNum < secondNum)
        {
            Console.WriteLine();
            Console.WriteLine("{0} {1}", secondNum, firstNum);
        }
        return;
    }
}