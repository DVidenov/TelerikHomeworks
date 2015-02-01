using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a Catalan number: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger divider1 = 1;
        BigInteger divider2 = 1;

        if (n > 0 && n < 100)
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                divider1 *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                divider2 *= i;
            }
            BigInteger result = divider1 / divider2;
            Console.WriteLine("{0} Catalan number is: {1}",n ,result);
        }
        else
        {
            Console.WriteLine("The number must be above than 0");
        }
    }
}