//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” 
//(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
//and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
using System;
class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter a time: ");
        try
        {
            DateTime beer = DateTime.Parse(Console.ReadLine());

            if (beer.Hour >= 13 || beer.Hour < 3)
            {
                Console.WriteLine("It is a beer time");
            }
            else
            {
                Console.WriteLine("It is not a beer time");
            }
        }
        catch(Exception)
        {

                Console.WriteLine("Invalid time");
        }
    }
}