//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
using System;
using System.Text;
class DecToBin
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int deciimal = int.Parse(Console.ReadLine());
        int remind;
        StringBuilder binary = new StringBuilder();

        while(deciimal>0)
        {
            int index = 0;
            remind = deciimal % 2;

            binary.Insert(index, remind);

            deciimal /= 2;
            index++;
        }
        Console.WriteLine(binary);
    }
}