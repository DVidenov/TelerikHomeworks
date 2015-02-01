using System;
class Calculate
{
    static void Main()
    {
        Console.WriteLine("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number k: ");
        int k = int.Parse(Console.ReadLine());
        int result1 = 1;
        int counter1 = 1;
        int counter2 = 1;
        int result2 = 1;
        int counter3 = 1;
        int result3 = 1;
        int c = n - k;
        int d = result2 * c;
        while (counter1 < n)
        {
            result1 *= n;
            n--;
        }
        while (counter2 < k)
        {
            result2 *= k;
            k--;
        }
        while (counter3 < c)
        {
            result3 *= c;
            c--;
        }
        Console.WriteLine(result1/ (result2* result3));
    }
}