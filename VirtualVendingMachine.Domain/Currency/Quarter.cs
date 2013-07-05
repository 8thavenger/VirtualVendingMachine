using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualVendingMachine.Domain.Currency
{
    public class Quarter : USCurrency
    {
        public override decimal Value
        {
            get { return 0.25M; }
        }
    }
}
