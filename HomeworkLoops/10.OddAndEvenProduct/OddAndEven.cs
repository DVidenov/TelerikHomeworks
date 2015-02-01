using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int productOdd = 1;
        int productEven = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                productEven *= int.Parse(numbers[i]);
            }
            else
            {
                productOdd *= int.Parse(numbers[i]);
            }
        }
        if (Equals(productOdd, productEven))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}