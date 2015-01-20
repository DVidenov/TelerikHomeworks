using System;
class QuotesInStrings
{
    static void Main()
    {
        string without = "The \"use\" of quotations causes difficulties.";
        string withquote = @"The ""use"" of quotations causes difficulties.";
         
        Console.WriteLine(without);
        Console.WriteLine(withquote);
    }
}
