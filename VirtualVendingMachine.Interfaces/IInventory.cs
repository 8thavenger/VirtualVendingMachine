using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualVendingMachine.Interfaces
{
    public interface IInventory
    {
        string Selector { get; }
        string Quantity { get; }
        string Description { get; }
        string Price { get; }
    }
}
