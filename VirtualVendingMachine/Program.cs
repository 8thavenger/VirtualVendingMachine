using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualVendingMachine.Interfaces;

namespace VirtualVendingMachine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IVirtualVendingMachine controller = new VirtualVendingMachine.Domain.VendingMachine();
            Application.Run(new frmMain(controller));
        }
    }
}
