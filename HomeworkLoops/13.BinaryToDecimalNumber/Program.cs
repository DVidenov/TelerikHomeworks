using System;
using System.Numerics;
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Binary number:");
        string binary = Console.ReadLine();

        long num = 0;
        int pow = 1;
        for (int i = binary.Length-1; i >= 0; i--)
        {
            int sign = binary[i] - 48;
            if (sign==1)
            {
                num += sign + pow;
            }
            pow *= 2;
        }
        Console.WriteLine(num);

    }
}