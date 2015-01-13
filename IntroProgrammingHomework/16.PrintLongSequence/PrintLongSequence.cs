using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + ",");
            }
            else
            {
                Console.WriteLine(-i);
                if (i < 1000)
                {
                    Console.WriteLine(",");
                }
            }
        }
        Console.WriteLine();

    }

}
