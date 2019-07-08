using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    public class Currency
    {
        private int quantidade;
        private string tipo;
        private decimal chaos_value;


        public Currency(string tipo, decimal chaos_value, int quantidade = 0)
        {
            this.quantidade = quantidade;
            this.tipo = tipo;
            this.chaos_value = chaos_value;
        }

        // Currency getters
        public int getQuantidade()
        {
            return this.quantidade;
        }
        public string getTipo()
        {
            return this.tipo;
        }
        public decimal getChaosValue()
        {
            return this.chaos_value;
        }

        // Currency setters
        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public void setChaosValue(decimal chaos_value)
        {
            this.chaos_value = chaos_value;
        }
    }
}
