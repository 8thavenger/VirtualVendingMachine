using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualVendingMachine.Interfaces
{
    public interface IVendingMachineForm
    {
        string CurrentValue { set; }
        void DispenseProduct(string productName);
        void DispenseCoin(string coin);
        void DisplayInventory(IEnumerable<IInventory> inventory);
    }
}
