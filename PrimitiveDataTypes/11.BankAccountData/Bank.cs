using System;
class Bank
{
    static void Main()
    {
        //name Input
        Console.WriteLine("Please enter holder name:");
        string name = Console.ReadLine();
        if (name == "Denislav Zhorov Videnov")
        {
            //account
            decimal balance = 4839.5M;
            string bankName = "FIbank";
            object IBAN = "BG80 BNBG 9661 1020 3456 78";
            long creditCard1 = 4061724061724061;
            long creditCard2 = 5115915115915118;
            long creditCard3 = 8472398472348923;

            //account information
            Console.WriteLine("Hello Mr. or Mrs.:{0}", name);
            Console.WriteLine("Your balance is:{0}", balance);
            Console.WriteLine("Your bank is:{0}", bankName);
            Console.WriteLine("Your IBAN is:{0}", IBAN);
            Console.WriteLine("Credit Card1:{0}", creditCard1);
            Console.WriteLine("Credit Card2:{0}", creditCard2);
            Console.WriteLine("Credit Card3:{0}", creditCard3);



        }


    }


}