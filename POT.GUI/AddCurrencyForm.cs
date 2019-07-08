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
using System.Text.RegularExpressions;

namespace POT.GUI
{
    public partial class AddCurrencyForm : Form
    {
        private CurrencyBank bank;

        public AddCurrencyForm(CurrencyBank bank)
        {
            InitializeComponent();
            this.bank = bank;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[0-9]*$");
            typeTxtBox.Enabled = false;
            quantityTxtBox.Enabled = false;
            if(typeTxtBox.Text != "")
            {
                if (quantityTxtBox.Text != "") { 
                    if(bank.SearchCurrencyType(typeTxtBox.Text) != -1)
                    {
                        if(regex.IsMatch(quantityTxtBox.Text)){
                            bank.AddCurrency(typeTxtBox.Text, Convert.ToInt32(quantityTxtBox.Text));
                            this.Close();
                        }
                        else
                        {
                            errorTxtBox.Text = "Quantity only accepts numbers.";
                            typeTxtBox.Enabled = true;
                            quantityTxtBox.Enabled = true;
                        }
                    }
                    else
                    {
                        errorTxtBox.Text = "There is no such type.";
                        typeTxtBox.Enabled = true;
                        quantityTxtBox.Enabled = true;
                    }
                }
                else
                {
                    errorTxtBox.Text = "Quantity is not filled.";
                    typeTxtBox.Enabled = true;
                    quantityTxtBox.Enabled = true;
                }
            }
            else
            {
                errorTxtBox.Text = "Type is not filled.";
                typeTxtBox.Enabled = true;
                quantityTxtBox.Enabled = true;
            }
        }
    }
}
