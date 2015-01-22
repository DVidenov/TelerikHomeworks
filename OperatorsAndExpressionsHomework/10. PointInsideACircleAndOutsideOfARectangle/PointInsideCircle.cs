using System;
class PointInsideCircle
{
    static void Main()
    {
        Console.WriteLine("Enter point, x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter point, y: ");
        double y = double.Parse(Console.ReadLine());
        double radius = 1.5;
        bool InCircleOutRectangle =((x-1)*(x-1)+(y-1)*(y-1))<=1.5*1.5 &&((x<-1||x>5)&&(y<-1||y>1));
        Console.WriteLine("InSide K and outside of R: "+ InCircleOutRectangle);
    }
}
