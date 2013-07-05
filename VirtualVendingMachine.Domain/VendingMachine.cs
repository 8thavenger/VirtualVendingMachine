using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualVendingMachine.Interfaces;

namespace VirtualVendingMachine.Domain
{
    public class VendingMachine : IVirtualVendingMachine
    {
        public void InsertCoin(ICoin coin)
        {
            throw new NotImplementedException();
        }

        public void MakeSelection(string selectorKey)
        {
            throw new NotImplementedException();
        }

        public void CancelTransaction()
        {
            throw new NotImplementedException();
        }

        public void Subscribe(IVendingMachineForm userInterface)
        {
            
        }

        public void Remove(IVendingMachineForm userInterface)
        {

        }
    }
}
