using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    //This class is part of the object returned by poe.ninja api
    public class CurrencyDetails
    {
        public int id { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public int poeTradeId { get; set; }
    }
}
