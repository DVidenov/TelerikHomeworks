using System;
class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter your weight: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your weight on the Moon will be: " + number * 0.17);
    }
}