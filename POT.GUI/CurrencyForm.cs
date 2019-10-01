using POT.Logic;
using System;
using System.IO;
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
        private string league = "Standard";
        public currencyForm()
        {
            InitializeComponent();
        }

        private async void currencyForm_Load(object sender, EventArgs e)
        {

            if (File.Exists("CurrencyData.xml"))
            {
                potDataSet1.ReadXml("CurrencyData.xml");
                bank = new CurrencyBank();
                bank.SetPOTDataSet(potDataSet1);
            }
            else
            {
                CurrencyOverview ninjaCurrency;
                NinjaConnection ninjaConnect = new NinjaConnection();
                ninjaCurrency = await ninjaConnect.RunAsync(league);
                bank = new CurrencyBank(ninjaCurrency.lines);
                potDataSet1 = bank.GetPOTDataSet();
            }
            totalTxtBox.Text = bank.GetTotal();
            leagueTxtBox.Text = league;
            dataGridView1.Refresh();
        }

        private void currencyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfirmExitForm confirmExitForm = new ConfirmExitForm();
            if(confirmExitForm.ShowDialog() == DialogResult.Yes)
            {
                potDataSet1.WriteXml("CurrencyData.xml");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potDataSet1.WriteXml("CurrencyData.xml");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            totalTxtBox.Text = bank.GetTotal();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.ResetQuantity();
            potDataSet1 = bank.GetPOTDataSet();
            totalTxtBox.Text = bank.GetTotal();
            dataGridView1.Refresh();
        }

        private async void updateChaosValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action sleep = delegate() { Thread.Sleep(3000); };
            Action msg = delegate () { msgTxtBox.Text = ""; };
            AsyncCallback clear = delegate (IAsyncResult ar) { msgTxtBox.Invoke(msg); sleep.EndInvoke(ar); };
            msgTxtBox.Text = "Getting data from poe.ninja...";
            try
            {
                await bank.UpdateChaosValues(league);
                potDataSet1 = bank.GetPOTDataSet();
                totalTxtBox.Text = bank.GetTotal();
                dataGridView1.Refresh();
                msgTxtBox.Text = "Getting data from poe.ninja... Success!";
            }catch(Exception ex)
            {
                msgTxtBox.Text = "Error getting data, check league spelling.";
            }
            sleep.BeginInvoke(clear, null);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            league = leagueTxtBox.Text;
            updateChaosValuesToolStripMenuItem.PerformClick();   
        }
    }
}
