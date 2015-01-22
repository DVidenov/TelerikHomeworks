using System;
class BitWiseExtract
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int a = int.Parse(Console.ReadLine());
        int bitePosition = (byte)((a >> 3) & 1);
        Console.WriteLine("The bit of the third position is: "+bitePosition);
    }
}