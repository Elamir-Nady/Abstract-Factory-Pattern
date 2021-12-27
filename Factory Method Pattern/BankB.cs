using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class BankB : IBank
    {
        public string Withdrow()
        {
            return "Your Request IS Handling By BankB";
        }
    }
}
