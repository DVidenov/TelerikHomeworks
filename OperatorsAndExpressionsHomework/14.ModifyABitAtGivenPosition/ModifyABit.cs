using System;
class ModifyABit
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value: ");
        byte v = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        byte p = byte.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        int newValue;
        int bitAtRight;
        if (v == 1)
        {
            bitAtRight = 1 << p;
            newValue = n & bitAtRight;
            Console.WriteLine(Convert.ToString(newValue, 2).PadLeft(32, '0'));
            Console.WriteLine("result = " + newValue);
        }
        else if (v == 0) ;
        {
            bitAtRight = ~(1 << p);
            newValue = n & bitAtRight;
            Console.WriteLine(Convert.ToString(newValue, 2).PadLeft(32, '0'));
            Console.WriteLine("Result: " + newValue);
        }
        {
            Console.WriteLine("Invalid input");
        }
    }
}