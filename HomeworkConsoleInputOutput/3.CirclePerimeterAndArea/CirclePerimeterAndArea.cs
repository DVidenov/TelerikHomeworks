//Write a program that reads the radius r of a circle and prints-
//its perimeter and area formatted with 2 digits after the decimal point.
using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter radios of circle: ");
        double radios = double.Parse(Console.ReadLine());
        double perimeter = (radios * 2) * Math.PI;
        double area = (radios * radios) * Math.PI;
        {
            Console.WriteLine("The perimeter is: {0}",Math.Round (perimeter,2));
            Console.WriteLine("The area is: {0}",Math.Round (area,2));
        }
    }
}
