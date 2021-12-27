using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class BankFactory : IBankFactory
    {
        public IBank GetBank(string BankCode)
        {
            switch (BankCode)
            {
                case "123456": return new BankA(); 
                case "111111": return new BankB(); 


            }
            return null;
        }

        public IpaymentCard GetGard(string CardNumber)
        {
            switch (CardNumber)
            {
                case "123456111": return new VisaCard();
                case "111111111": return new VisaCard();
                case "111111456": return new MasterCard();
                case "123456456": return new MasterCard();

            }
            return null;
        }
    }
}
