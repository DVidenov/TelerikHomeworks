using System;
class ThirdDigit
{

    static void Main()
    {
        Console.WriteLine("Enter your number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}=7", a);
        if (a < 100)
        {
            Console.WriteLine("The number must be at least three digits");
            return;
        }
        Console.WriteLine("The thirt digit (right to left) {0} is seven)", ThirdDigitIsSeven(a) ? "Is" : "Is not");
    }
            bool ThirdDigitIsSeven(int a)
            {
                if ((a /100 ) % 10 != 7 ) return false;
                return true
            }
        }
}
}