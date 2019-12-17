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
        private string league;
        public currencyForm()
        {
            InitializeComponent();
        }

        private async void currencyForm_Load(object sender, EventArgs e)
        {
            Leagues leagues = new Leagues();
            List<PoeLeague> poeLeagues;
            PoeConnection poeConnect = new PoeConnection();

            //Loads data into league list
            poeLeagues = await poeConnect.RunAsyncLeagues();
            leagues.setLeagues(poeLeagues);
            league = Properties.Settings.Default.lastLeague;
            // Assigning data source changes the index, and the function that is run afterwards
            // assigns the currently selected value to the variable league, nullifying the settings.lastLeague
            // Because of this the handler is added after the data source, instead of being added in the designer
            leaguesBox.DataSource = leagues.getLeagues();
            

            // if saved league is no longer available, sets it to standard
            if (!leagues.IsLeagueAvailable(league))
            {
                league = "Standard";
                this.leaguesBox.SelectedIndexChanged += new EventHandler(this.leaguesBox_SelectedIndexChangedAsync);
            }
            //Current workaround to not lose quantity data when getting league data because of the event
            else if(!File.Exists(league + "CurrencyData.xml"))
            {
                this.leaguesBox.SelectedIndexChanged += new EventHandler(this.leaguesBox_SelectedIndexChangedAsync);
                leaguesBox.SelectedIndex = leaguesBox.Items.IndexOf(league);
            }
            else
            {
                leaguesBox.SelectedIndex = leaguesBox.Items.IndexOf(league);
                this.leaguesBox.SelectedIndexChanged += new EventHandler(this.leaguesBox_SelectedIndexChangedAsync);
            }
            

            //Loads data into bank from xml if exists
            if (File.Exists(league + "CurrencyData.xml"))
            {
                potDataSet1.ReadXml(league + "CurrencyData.xml");
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
                bank.SetPOTDataSet(potDataSet1);
            }

            totalTxtBox.Text = bank.GetTotal();
            dataGridView1.Refresh();
        }

        //When closing asks for confirmation
        private void currencyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfirmExitForm confirmExitForm = new ConfirmExitForm();

            //Saves the xml and league setting before closing if the user wants to
            if(confirmExitForm.ShowDialog() == DialogResult.Yes)
            {
                potDataSet1.WriteXml(league + "CurrencyData.xml");
                Properties.Settings.Default.lastLeague = leaguesBox.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }
        }

        //Data->Save button click event handler
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            potDataSet1.WriteXml(league + "CurrencyData.xml");
            Properties.Settings.Default.lastLeague = leaguesBox.SelectedItem.ToString();
            Properties.Settings.Default.Save();
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
                totalTxtBox.Text = bank.GetTotal();
                dataGridView1.Refresh();
                msgTxtBox.Text = "Getting data from poe.ninja... Success!";
            
            //exception message will be later saved to log file
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            sleep.BeginInvoke(clear, null);
            bank.SetPOTDataSet(potDataSet1);
        }

        //league change event handler
        private async void leaguesBox_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            // saving xml if league changed, to prevent user quantity data
            potDataSet1.WriteXml(league + "CurrencyData.xml");

            league = leaguesBox.Text;
            // if a save file for the league exists, loads that instead of ninja data
            if (File.Exists(league + "CurrencyData.xml"))
            {
                potDataSet1.Clear();
                potDataSet1.ReadXml(league + "CurrencyData.xml");
                bank = new CurrencyBank();
                bank.SetPOTDataSet(potDataSet1);
            }
            else
            {
                //get data for the selected league
                Action sleep = delegate () { Thread.Sleep(3000); };
                Action msg = delegate () { msgTxtBox.Text = ""; };
                AsyncCallback clear = delegate (IAsyncResult ar) { msgTxtBox.Invoke(msg); sleep.EndInvoke(ar); };
                msgTxtBox.Text = "Getting data from poe.ninja...";
                try
                {
                    
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
                    Console.WriteLine(ex.Message);
                }
                sleep.BeginInvoke(clear, null);
                bank.SetPOTDataSet(potDataSet1);
            }
        }
    }
}
