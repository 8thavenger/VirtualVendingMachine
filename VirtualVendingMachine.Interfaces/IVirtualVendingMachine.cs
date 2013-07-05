using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualVendingMachine.Interfaces
{
    public interface IVirtualVendingMachine : IObserverSubject
    {
        void InsertCoin(ICoin coin);
        void MakeSelection(string selectorKey);
        void CancelTransaction();
    }
}
