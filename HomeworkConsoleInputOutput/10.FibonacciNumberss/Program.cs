using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter number n = ");
        int n = int.Parse(Console.ReadLine());
        int numberOne = 0;
        int numberTwo = 1;
        int sum;

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}", numberOne+", ");
            sum = numberOne + numberTwo;
            numberOne = numberTwo;
            numberTwo = sum;
        }
    }
}