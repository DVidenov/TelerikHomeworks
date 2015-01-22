using System;
class Devide
{
    static void Main()
    {
        Console.WriteLine("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        bool ifIsDivisable = (number % 35 == 0);
        Console.WriteLine("This number is divisable on 7 and 5: {0}", ifIsDivisable);
    }
}
