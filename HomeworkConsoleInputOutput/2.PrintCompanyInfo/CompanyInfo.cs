// Print Company Information
using System;
class CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter phone number: ");
        long companyPhoneNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Ënter fax number: ");
        long faxNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter website: ");
        string website = Console.ReadLine();

        Console.WriteLine("Enter first name of Manager: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter last name of Manager");
        string lastName = Console.ReadLine();
        Console.WriteLine("Ënter age of Manager: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter phone of Manager: ");
        long phoneNumberManager = long.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: "+companyAddress);
        Console.WriteLine("Phone number: "+ companyPhoneNumber);
        Console.WriteLine("Fax number: "+faxNumber);
        Console.WriteLine("Web site: "+website);
        Console.WriteLine("Manager name {0} {1} (age:{2} , tel. +{3})",firstName,lastName,age,phoneNumberManager);
    }
}