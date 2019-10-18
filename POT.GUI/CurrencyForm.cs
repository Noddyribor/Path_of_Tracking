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
        private League[] leagues;
        private string league;
        public currencyForm()
        {
            InitializeComponent();
        }

        private async void currencyForm_Load(object sender, EventArgs e)
        {
            bool leagueValid;

            //Loads data into league list
            PoeConnection poeConnect = new PoeConnection();
            leagues = await poeConnect.RunAsyncLeagues();
            Console.WriteLine(leagues);
            league = Properties.Settings.Default.lastLeague;


            foreach (League item in leagues)
            {
                if (item.id.Equals(league))
                {
                    leaguesBox.Text = league;
                    leagueValid = true;
                    break;
                }
            }
            leagueValid =  false;


            
            if (!leagueValid)
            {
                leaguesBox.Text = "Standard";
                leagueSaveBtn.PerformClick();
            }



            //Loads data into bank from xml if exists
            if (File.Exists("CurrencyData.xml"))
            {
                potDataSet1.ReadXml("CurrencyData.xml");
                bank = new CurrencyBank();
                bank.SetPOTDataSet(potDataSet1);
            }
            //Gets data from poe.ninja when xml doesn't exist
            else
            {
                CurrencyOverview ninjaCurrency;
                NinjaConnection ninjaConnect = new NinjaConnection();
                ninjaCurrency = await ninjaConnect.RunAsync(league);
                bank = new CurrencyBank(ninjaCurrency.lines);
                potDataSet1.Clear();
                potDataSet1.Merge(bank.GetPOTDataSet());
            }

            totalTxtBox.Text = bank.GetTotal();
            dataGridView1.Refresh();
        }

        //When closing asks for confirmation
        private void currencyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfirmExitForm confirmExitForm = new ConfirmExitForm();

            //Saves the xml before closing if user wants to
            if(confirmExitForm.ShowDialog() == DialogResult.Yes)
            {
                potDataSet1.WriteXml("CurrencyData.xml");
            }
        }

        //Data->Save button click event handler
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potDataSet1.WriteXml("CurrencyData.xml");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Updates total when cells are edited
            totalTxtBox.Text = bank.GetTotal();
        }

        //Data->Reset button click event handler
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.ResetQuantity();
            potDataSet1.Clear();
            potDataSet1.Merge(bank.GetPOTDataSet());
            totalTxtBox.Text = bank.GetTotal();
            dataGridView1.Refresh();
        }

        //Data->Update Chaos Values button event handler
        private async void updateChaosValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action sleep = delegate() { Thread.Sleep(3000); };
            Action msg = delegate () { msgTxtBox.Text = ""; };
            AsyncCallback clear = delegate (IAsyncResult ar) { msgTxtBox.Invoke(msg); sleep.EndInvoke(ar); };
            msgTxtBox.Text = "Getting data from poe.ninja...";
            try
            {
                //gets up-to-date values from poe.ninja
                await bank.UpdateChaosValues(league);
                potDataSet1.Clear();
                potDataSet1.Merge(bank.GetPOTDataSet());
                totalTxtBox.Text = bank.GetTotal();
                dataGridView1.Refresh();
                msgTxtBox.Text = "Getting data from poe.ninja... Success!";
            
            //exception message will be later saved to log file
            }catch(Exception ex)
            {  
            }
            sleep.BeginInvoke(clear, null);
        }

        // League save button event handler
        private async void leagueSaveButton_ClickAsync(object sender, EventArgs e)
        {
            //get data for the selected league
            Action sleep = delegate () { Thread.Sleep(3000); };
            Action msg = delegate () { msgTxtBox.Text = ""; };
            AsyncCallback clear = delegate (IAsyncResult ar) { msgTxtBox.Invoke(msg); sleep.EndInvoke(ar); };
            msgTxtBox.Text = "Getting data from poe.ninja...";
            try
            {
                league = leaguesBox.Text;
                CurrencyOverview ninjaCurrency;
                NinjaConnection ninjaConnect = new NinjaConnection();
                ninjaCurrency = await ninjaConnect.RunAsync(league);
                bank = new CurrencyBank(ninjaCurrency.lines);
                potDataSet1.Clear();
                potDataSet1.Merge(bank.GetPOTDataSet());
                totalTxtBox.Text = bank.GetTotal();
                dataGridView1.Refresh();
                msgTxtBox.Text = "Getting data from poe.ninja... Success!";
            }
            catch (Exception ex)
            {

            }
            sleep.BeginInvoke(clear, null);
        }
    }
}
