﻿using System;
class ExchangeVariables
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Values before exchange:");
        Console.WriteLine("a="+a);
        Console.WriteLine("b="+b);
        Console.WriteLine("Values after exchange:");
        int change = a;
        a = b;
        b = change;
        Console.WriteLine("a="+a);
        Console.WriteLine("b="+b);
    }
}