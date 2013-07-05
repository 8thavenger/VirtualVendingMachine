using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualVendingMachine.Domain.Currency
{
    public class Dime: USCurrency
    {
        public override decimal Value
        {
            get { return 0.1M; }
        }
    }
}
