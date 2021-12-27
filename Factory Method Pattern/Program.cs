using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string CardNumber, CardCode,BankCode;
            BankFactory bankFactory = new BankFactory();
            Console.WriteLine("Enter Your Card Number");

            CardNumber = Console.ReadLine();

            BankCode = CardNumber.Substring(0, 6);
            CardCode = CardNumber.Substring(0, 9);
            IBank bank = bankFactory.GetBank(BankCode);

            Console.WriteLine(bank.Withdrow());

            IpaymentCard Card= bankFactory.GetGard(CardCode);
            Console.WriteLine(Card.GetName());
            Console.WriteLine(Card.GetProvidorInfo());



        }
    }
}
