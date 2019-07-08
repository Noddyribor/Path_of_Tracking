using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POT.Logic
{
    public class CurrencyBank
    {
        List<Currency> bank = new List<Currency>();

        public CurrencyBank(CurrencyOverviewLine[] lines)
        {
            foreach (CurrencyOverviewLine line in lines)
            {
                this.bank.Add(new Currency(line.currencyTypeName, line.chaosEquivalent));
            }
        }

        public void AddCurrency(string tipo, int quantidade)
        {
            int i = this.SearchCurrencyType(tipo);
            if (i != -1)
            {
                this.bank[i].setQuantidade(this.bank[i].getQuantidade() + quantidade);
            }
            else
            {
                Console.WriteLine("Error: Type of currency doesn't exist.");
                Console.ReadKey();
            }
        }

        public void AddCurrency()
        {
            string[] opcs = { "" };
            string tipo;
            int quantidade;
            Menu menu = new Menu("Add Currency", opcs, "");
            menu.ShowTitle();
            tipo = Terminal.ReadString("Type of currency to insert: ");
            quantidade = Terminal.ReadInteger("Quantity to insert: ");
            this.AddCurrency(tipo, quantidade);
        }

        public string GetTotal()
        {
            decimal total=0;
            string sTotal;
            foreach (Currency curr in this.bank)
            {
                total += curr.getQuantidade() * curr.getChaosValue();
            }
            if(total < bank[SearchCurrencyType("Exalted Orb")].getChaosValue())
            {
                sTotal = total.ToString() + " chaos";
            }
            else
            {
                sTotal = (total / bank[SearchCurrencyType("Exalted Orb")].getChaosValue()).ToString() + " exalted";
            }
            return sTotal;
        }

        public void RemCurrency(string tipo, int quantidade)
        {
            int i = this.SearchCurrencyType(tipo);
            if (i != -1)
            {
                this.bank[i].setQuantidade(this.bank[i].getQuantidade() - quantidade);
            }
            else
            {
                Console.WriteLine("Error: Type of currency doesn't exist.");
                Console.ReadKey();
            }
        }

        public void RemCurrency()
        {
            string[] opcs = { "" };
            string tipo;
            int quantidade;
            Menu menu = new Menu("Remove Currency", opcs, "");
            menu.ShowTitle();
            tipo = Terminal.ReadString("Type of currency to remove: ");
            quantidade = Terminal.ReadInteger("Quantity to remove:");
            this.RemCurrency(tipo, quantidade);
        }

        public int SearchCurrencyType(string tipo)
        {
            for (int i = 0; i < this.bank.Count; i++)
            {
                if (this.bank[i].getTipo() == tipo)
                {
                    return i;
                }
            }
            return -1;
        }

        public string[] getCurrencyNames()
        {
            string[] currencyArray = new string[bank.Count];
            int i = 0;
            foreach (Currency curr in this.bank)
            {
                currencyArray[i] = curr.getTipo();
                i++;
            }
            return currencyArray;
        }

        public string[] getChaosValues()
        {
            string[] currencyArray = new string[bank.Count];
            int i = 0;
            foreach (Currency curr in this.bank)
            {
                currencyArray[i] = curr.getChaosValue().ToString();
                i++;
            }
            return currencyArray;
        }

        public string[] getQuantity() {
            string[] currencyArray = new string[bank.Count];
            int i = 0;
            foreach (Currency curr in this.bank)
            {
                currencyArray[i] = curr.getQuantidade().ToString();
                i++;
            }
            return currencyArray;

        }

        public string[] getChaosUnit()
        {
            string[] currencyArray = new string[bank.Count];
            int i = 0;
            foreach (Currency curr in this.bank)
            {
                currencyArray[i] = (curr.getQuantidade()*curr.getChaosValue()).ToString()+" chaos";
                i++;
            }
            return currencyArray;
        }
    }
}
