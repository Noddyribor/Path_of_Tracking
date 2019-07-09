using System;
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
        POTDataSet bank = new POTDataSet();
   

        public CurrencyBank(CurrencyOverviewLine[] lines)
        {
            POTDataSet.CurrencyRow row = bank.Currency.NewCurrencyRow();
            int i=0;
            foreach (CurrencyOverviewLine line in lines)
            {
                row.Type = line.currencyTypeName;
                row.ChaosValue = line.chaosEquivalent;
                bank.Currency.Rows.InsertAt(row, i);
            }
        }
        

        public void AddCurrency(int index, int quantity)
        {
            POTDataSet.CurrencyRow row = bank.Currency.NewCurrencyRow();
            DataView dataView = new DataView(bank.Currency);
            POTDataSet.CurrencyRow currencyRow = (POTDataSet.CurrencyRow) bank.Currency.Rows[index];
            row.Quantity += quantity;
            row.ChaosValue = currencyRow.ChaosValue;
            row.Type = currencyRow.Type;
            bank.Currency.Rows.InsertAt(row, index);
        }

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

        public void RemCurrency(int index, int quantity)
        {
            POTDataSet.CurrencyRow row = bank.Currency.NewCurrencyRow();
            DataView dataView = new DataView(bank.Currency);
            POTDataSet.CurrencyRow currencyRow = (POTDataSet.CurrencyRow)bank.Currency.Rows[index];
            row.Quantity -= quantity;
            row.ChaosValue = currencyRow.ChaosValue;
            row.Type = currencyRow.Type;
            bank.Currency.Rows.InsertAt(row, index);
        }

        public int SearchCurrencyType(string type)
        {
            POTDataSet.CurrencyRow[] row = (POTDataSet.CurrencyRow[])bank.Currency.Select(string.Format("Type = {0}", type));
            return bank.Currency.Rows.IndexOf(row[0]);
        }
    }
}
