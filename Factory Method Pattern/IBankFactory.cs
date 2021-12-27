using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    interface IBankFactory
    {
        IBank GetBank(string BankCode);
        IpaymentCard GetGard(string CardNumber);
    }
}
