using System;
class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        int radius = 2;
        bool isItInTheCircle = (x * x + y * y) <= radius * radius;
        Console.WriteLine("It is in the circle: " + isItInTheCircle);
    }
}