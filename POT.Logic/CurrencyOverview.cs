using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    //This class is part of the object returned by poe.ninja api
    public class CurrencyOverview
    {
        public CurrencyOverviewLine[] lines { get; set; }
        public CurrencyDetails[] currencyDetails { get; set; }
    }
}
