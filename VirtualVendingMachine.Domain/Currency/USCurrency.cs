using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualVendingMachine.Interfaces;

namespace VirtualVendingMachine.Domain.Currency
{
    public abstract class USCurrency : ICoin
    {
        public abstract decimal Value {get;}
    }
}
