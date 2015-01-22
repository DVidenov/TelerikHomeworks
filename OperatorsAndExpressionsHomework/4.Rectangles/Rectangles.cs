using System;
class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter the width of rectangle: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the hight of the rectangle: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the rectangle is:"+a * b);
        Console.WriteLine("The perimeter of the rectangle is:"+ ((2*a)+(2*b)));
    }
}