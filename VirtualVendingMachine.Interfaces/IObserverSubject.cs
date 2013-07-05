using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualVendingMachine.Interfaces
{
    public interface IObserverSubject
    {
        void Subscribe(IVendingMachineForm userInterface);
        void Remove(IVendingMachineForm userInterface);
    }
}
