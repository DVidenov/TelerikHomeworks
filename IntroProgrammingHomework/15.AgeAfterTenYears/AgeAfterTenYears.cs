using System;
class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birth date: ");
        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        int age = (int)((DateTime.Now - BirthDay).TotalDays / 365.242199);
        Console.WriteLine("After ten years you will be at the age of " + (age + 10));
    }
}
