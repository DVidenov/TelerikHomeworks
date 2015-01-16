using System;
class NullArithmetic
{
    static void Main()
    {
        int? a1 = null;
        a1 = 6;
        double? b1 = null;
        b1 = 7;
        Console.WriteLine(a1.HasValue);
        Console.WriteLine(b1.HasValue);
        int a = 7;
        int b = a1.Value;
        a = a1.Value;
        Console.WriteLine(a1);
    }
}