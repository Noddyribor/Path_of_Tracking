using POT.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POT.GUI
{
    public partial class currencyForm : Form
    {
        private CurrencyBank bank;
        public currencyForm()
        {
            InitializeComponent();
        }

        private async void currencyForm_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            CurrencyOverview ninjaCurrency;
            
            NinjaConnection ninjaConnect = new NinjaConnection();
            nameTxtBox.Text = "Getting Data...";
            ninjaCurrency = await ninjaConnect.RunAsync();
            bank = new CurrencyBank(ninjaCurrency.lines);
            nameTxtBox.Lines = bank.getCurrencyNames();
            chaosValueTxtBox.Lines = bank.getChaosValues();
            quantityTxtBox.Lines = bank.getQuantity();
            totalUnitTxtBox.Lines = bank.getChaosUnit();
            totalTxtBox.Text = bank.GetTotal();
            chaosValueTxtBox.Height = (chaosValueTxtBox.Font.Height+2) * chaosValueTxtBox.Lines.Length;
            nameTxtBox.Height = (nameTxtBox.Font.Height+2) * nameTxtBox.Lines.Length;
            quantityTxtBox.Height = (quantityTxtBox.Font.Height + 2) * quantityTxtBox.Lines.Length;
            totalUnitTxtBox.Height = (totalUnitTxtBox.Font.Height + 2) * totalUnitTxtBox.Lines.Length;
        }

        private void addCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCurrencyForm addCurrencyForm = new AddCurrencyForm(bank);
            addCurrencyForm.ShowDialog();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {

            nameTxtBox.Lines = bank.getCurrencyNames();
            chaosValueTxtBox.Lines = bank.getChaosValues();
            quantityTxtBox.Lines = bank.getQuantity();
            totalUnitTxtBox.Lines = bank.getChaosUnit();
            totalTxtBox.Text = bank.GetTotal();
        }
    }
}
