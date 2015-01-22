using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        string input = Console.ReadLine();
        int num = int.Parse(input);

        bool odd = (num % 2) != 0;
        Console.WriteLine("Is {0} odd ---> {1}", num, odd);
    }
}