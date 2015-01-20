using System;
class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Number 1: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Number 2: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        bool equal = Math.Abs(number1 - number2) < 0.000001;
        Console.WriteLine("number1 == number2: " + equal);
    }
}