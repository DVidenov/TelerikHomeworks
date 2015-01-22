//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;
class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int firstPosition = 3;
        int secondPosition = 24;

        int firstMask = 7 << firstPosition;
        int secondMask = 7 << secondPosition;

        int getNumberOne = n & firstMask;
        int getNumberTwo = n & secondMask;

        int change = (n & ~firstMask) & secondMask;
        int thirdMask = (getNumberOne >> firstPosition) << secondPosition;
        int fourthMask = (getNumberTwo >> secondPosition) << firstPosition;

        int result = (change | thirdMask) | fourthMask;

        Console.WriteLine("The result is: "+ result);
    }
}