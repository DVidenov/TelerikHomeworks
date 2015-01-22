using System;
class Trapeziods
{
    static void Main()
    {
        Console.WriteLine("Enter side, a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side, b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The trapezoid's area is: "+((a+b)/2)*c);
    }
}
