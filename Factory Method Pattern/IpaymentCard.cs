using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IpaymentCard
    {
        string GetName();
        string GetProvidorInfo();
    }
    public class VisaCard : IpaymentCard
    {
        public string GetName()
        {
            return "Visa Card";
        }

        public string GetProvidorInfo()
        {
            return "Visa";
        }
    }
    public class MasterCard : IpaymentCard
    {
        public string GetName()
        {
            return "Master Card";
        }

        public string GetProvidorInfo()
        {
            return "Master";
        }
    }
}
