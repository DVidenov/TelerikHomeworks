//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
using System;
class HexToDec
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number: ");
        string hexnum = (Console.ReadLine());
        long num = 0;
        long pow = 1;

        for (int i = hexnum.Length - 1; i >= 0; i--)
        {
            int sig;
            switch (hexnum[i])
            {
                case 'A': sig = 10;
                    break;
                case 'B': sig = 11;
                    break;
                case 'C': sig = 12;
                    break;
                case 'D': sig = 13;
                    break;
                case 'E': sig = 14;
                    break;
                case 'F': sig = 15;
                    break;
            }   
            num += sig * pow;
            pow *= 16;
        }
        Console.WriteLine(num);
    }
}