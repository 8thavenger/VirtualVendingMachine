using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualVendingMachine.Domain.Currency;
using VirtualVendingMachine.Interfaces;

namespace VirtualVendingMachine
{
    public partial class frmMain : Form, IVendingMachineForm
    {
        IVirtualVendingMachine controller = null;
        string selection = string.Empty;

        public frmMain(IVirtualVendingMachine vendingMachine)
        {
            InitializeComponent();
            vendingMachine.Subscribe(this);
            this.controller = vendingMachine;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.controller.Remove(this);
            base.OnClosing(e);
        }
        

        public string CurrentValue
        {
            set { lblDisplayValue.Text = value.Trim(); }
        }

        public void DispenseProduct(string productName)
        {
            lblSlot.Text = productName.Trim();
        }

        public void DispenseCoin(string coin)
        {
            lblSlot.Text = coin.ToString();
        }

        public void DisplayInventory(IEnumerable<IInventory> inventory)
        {
            lstInventory.Items.Clear();
            foreach (IInventory item in inventory)
                lstInventory.Items.Add(item.ToString());
        }

        private void Selector_Click(object sender, EventArgs e)
        {
            Button selector = (Button)sender;
            this.selection = this.selection + selector.Text;
            this.lblDisplayValue.Text = this.selection;
            if (this.selection.Length == 2)
            {
                this.controller.MakeSelection(this.selection);
            }
        }

        private void btn_Insert_Quarter_Click(object sender, EventArgs e)
        {
            this.lblDisplayValue.Text = String.Empty;
            this.controller.InsertCoin(new Quarter());
        }

        private void btn_Insert_Nickle_Click(object sender, EventArgs e)
        {
            this.lblDisplayValue.Text = String.Empty;
            this.controller.InsertCoin(new Nickel());
        }

        private void btn_Insert_Dime_Click(object sender, EventArgs e)
        {
            this.lblDisplayValue.Text = String.Empty;
            this.controller.InsertCoin(new Dime());
        }

        private void btn_Inser_Half_Dolar_Click(object sender, EventArgs e)
        {
            this.lblDisplayValue.Text = String.Empty;
            this.controller.InsertCoin(new HalfDollar());
        }
    }
}
