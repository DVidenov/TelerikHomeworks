//Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
using System;
class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how long will be the sequence: ");
        int sequence = int.Parse(Console.ReadLine());

        int input;
        int sum = 0;
        int maxvalue = int.MinValue;
        int minvalue = int.MaxValue;

        for (int i = 1; i <= sequence; i++)
        {
            Console.WriteLine("Enter the number{0}", i);
            input = int.Parse(Console.ReadLine());

            sum += input;
            if (input > maxvalue)
            {
                maxvalue = input;
            }
            if (input < minvalue)
            {
                minvalue = input;
            }
        }
        double avarage = (double)(sum) / (double)(sequence);
        Console.WriteLine("min={0}\nmaax={1}\nsum={2}\avarage={3}", minvalue, maxvalue, sum, avarage);
    }
}