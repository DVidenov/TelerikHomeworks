//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n 1-->int \n 2-->double \n 3--> string");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine("Enter an int:\n");
                int numint = int.Parse(Console.ReadLine());
                Console.WriteLine(numint);
                break;
            case 2: Console.WriteLine("Enter a double:\n");
                double numdouble = double.Parse(Console.ReadLine());
                Console.WriteLine(numdouble);
                break;
            case 3: Console.WriteLine("Enter a string:\n");
                string numstring = Console.ReadLine();
                Console.WriteLine(numstring);
                break;
            default: Console.WriteLine("Invalid number");
                break;
        }
    }
}