//Write a program that reads two positive integer numbers and prints how many numbers p exist 
//between them such that the reminder of the division by 5 is 0.
using System;
class NumberInInterval
{
    static void Main()
    {
        Console.WriteLine("Enter star num: ");
        int startNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end num: ");
        int endnum = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = startNum; i <= endnum; i++)
        {
            if (i % 5 == 0)
            {
                result++;
            }
        }
        Console.WriteLine("Points={0}", result);
    }
}