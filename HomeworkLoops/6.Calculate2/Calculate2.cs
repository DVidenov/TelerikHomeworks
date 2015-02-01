using System;
class Calculate2
{
    static void Main()
    {
        Console.WriteLine("Enter number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number K: ");
        int k = int.Parse(Console.ReadLine());
        int sum = 1;

        if (1 < k && k < n && n < 100)
        {
            for (int i = 1 + k; i <= n; i++)
            {
                sum *= i;
            }
        }
        else
        {
            Console.WriteLine("Can't be calculated");
        }
        Console.WriteLine(sum);
    }
}
