using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualVendingMachine.Domain.Currency
{
    public class CanadianQuarter : CanadianCurrency
    {
        public override decimal Value
        {
            get { return 0.26M; }
        }
    }
}
