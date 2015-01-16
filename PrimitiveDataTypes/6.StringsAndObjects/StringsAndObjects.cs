using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class StringsAndObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object c = a + " " + b;
        string objToString;
        Console.WriteLine(c);
        objToString = (string)c;
        Console.WriteLine(objToString);
    }
}
