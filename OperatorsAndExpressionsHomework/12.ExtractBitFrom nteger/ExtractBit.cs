using System;
class ExtractBit
{
    static void Main()
    {
        Console.WriteLine("ent bit");
        int n = int.Parse(Console.ReadLine());
        int position = (byte)((n >> 3) & 1);
        Console.WriteLine(position);
    }
}