using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace POT.Logic
{
    public class CurrencyBank
    {
        private POTDataSet bank;
        
        public CurrencyBank()
        {
            this.bank = new POTDataSet();
        }

        //Fills the bank with poe.ninja data
        public CurrencyBank(CurrencyOverviewLine[] lines)
        {
            this.bank = new POTDataSet();
            foreach (CurrencyOverviewLine line in lines)
            {
                POTDataSet.CurrencyRow row = bank.Currency.NewCurrencyRow();
                row.Quantity = 0;
                row.Type = line.currencyTypeName;
                row.ChaosValue = line.chaosEquivalent;

                //Adding chaos row because it's not shown at poe.ninja
                if(row.Type == "Engineer's Orb")
                {
                    POTDataSet.CurrencyRow chaosRow = bank.Currency.NewCurrencyRow();
                    chaosRow.Quantity = 0;
                    chaosRow.Type = "Chaos Orb";
                    chaosRow.ChaosValue = 1.00M;
                    bank.Currency.Rows.Add(chaosRow);
                }

                bank.Currency.Rows.Add(row);
            } 
        }
        
        //Resets all currency quantity
        public void ResetQuantity()
        {
            foreach(POTDataSet.CurrencyRow row in bank.Currency.Rows)
            {
                row.Quantity = 0;
            }
        }

        //Gets up-to-date currency values from poe.ninja
        public async Task UpdateChaosValues(string league)
        {
            CurrencyOverview ninjaCurrency;
            int i = 0;
            NinjaConnection ninjaConnection = new NinjaConnection();
            ninjaCurrency = await ninjaConnection.RunAsync(league);
            foreach(POTDataSet.CurrencyRow row in bank.Currency.Rows)
            {
                //Must check for chaos orb row, poe.ninja doesn't have a row for it
                if (row.Type != "Chaos Orb")
                {
                    row.ChaosValue = ninjaCurrency.lines[i].chaosEquivalent;
                    i++;
                }
            }
        }

        //Dataset getters and setters
        public POTDataSet GetPOTDataSet()
        {
            return bank;
        }
        public void SetPOTDataSet(POTDataSet dataset)
        {
            this.bank = dataset;
        }

        //Old function, keeping it just in case
        /*public void AddCurrency(int index, int quantity)
        {
            POTDataSet.CurrencyRow currencyRow = (POTDataSet.CurrencyRow)bank.Currency.Rows[index];
            int currencyQuantity = currencyRow.Quantity;
            bank.Currency.Rows[index].SetField<int?>("Quantity", currencyQuantity + quantity);
        }*/


        //gets total currency in chaos (or exalteds if chaos quantity >= exalted chaos value)
        public string GetTotal()
        {
            decimal total=0;
            string sTotal;
            POTDataSet.CurrencyRow[] rows = (POTDataSet.CurrencyRow[]) bank.Currency.Select();
            POTDataSet.CurrencyRow exaltedRow = (POTDataSet.CurrencyRow)bank.Currency.Rows[SearchCurrencyType("Exalted Orb")];
            foreach (POTDataSet.CurrencyRow curr in rows)
            {
                total += curr.Quantity * curr.ChaosValue;
            }
            if(total < exaltedRow.ChaosValue)
            {
                sTotal = total.ToString("0.##") + " chaos";
            }
            else
            {
                sTotal = (total / exaltedRow.ChaosValue).ToString("0.##") + " exalted";
            }
            return sTotal;
        }

        //old function, keeping it just in case
        /*public void RemCurrency(int index, int quantity)
        {
            POTDataSet.CurrencyRow currencyRow = (POTDataSet.CurrencyRow)bank.Currency.Rows[index];
            bank.Currency.Rows[index].SetField<int>("Quantity", currencyRow.Quantity - quantity);
        }*/

        //Finds the currency type and returns the index
        public int SearchCurrencyType(string type)
        {
            POTDataSet.CurrencyRow[] row = (POTDataSet.CurrencyRow[])bank.Currency.Select(string.Format("Type = '{0}'", type));
            return bank.Currency.Rows.IndexOf(row[0]);
        }
    }
}
