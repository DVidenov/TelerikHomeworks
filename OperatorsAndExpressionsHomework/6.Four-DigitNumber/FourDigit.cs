using System;
class FourDigit
{
    static void Main()
    {
        Console.Write("Enter four-digit number: ");
        int number = int.Parse(Console.ReadLine());

        while (number < 1000 || number > 9999)
        {
            Console.Write("You must enter four-digit number: ");
            number = int.Parse(Console.ReadLine());
        }

        int d = number % 10;
        int c = (number / 10) % 10;
        int b = (number / 100) % 10;
        int a = (number / 1000) % 10;

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Your number is: " + number);
        Console.WriteLine("The sum of the number is: " + (a + b + c + d));
        Console.WriteLine("Reversed number is: {3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("Last digit in front of the number is: {3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("Second and third digits exchanged is: {0}{2}{1}{3}", a, b, c, d);
    }
}
