using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                Console.Write(",");
            }
            else
            {
                if (1 < 1000)
                Console.WriteLine(-i);
                Console.Write(",");
            }
        }
    }

}
