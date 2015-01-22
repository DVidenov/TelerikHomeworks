//Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n, has value of 1

using System;
class CheckABit
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        {
            Console.WriteLine("Enter position: ");
            int p = int.Parse(Console.ReadLine());
            int mask = n >> p & 1;
            Console.WriteLine("The bit at this position is 1: " + ((n & mask) == 1));
        }
    }
}