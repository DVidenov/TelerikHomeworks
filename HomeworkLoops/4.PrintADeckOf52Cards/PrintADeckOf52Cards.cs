using System;
class PrintADeckOf52Cards
{
    static void Main()
    {
        char clubs = (char)9827;
        char diams = (char)9830;
        char hearts = (char)9829;
        char spades = (char)9824;
        for (int i = 2; i < 15; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9: Console.Write(i); break;
                    case 10: Console.Write(10); break;
                    case 11: Console.Write("Q"); break;
                    case 12: Console.Write("J"); break;
                    case 13: Console.Write("K"); break;
                    case 14: Console.Write("A"); break;
                }
                switch (j)
                {
                    case 1: Console.Write(spades); break;
                    case 2: Console.Write(clubs); break;
                    case 3: Console.Write(hearts); break;
                    case 4: Console.Write(diams + "\n"); break;
                }
            }
        }
    }
}