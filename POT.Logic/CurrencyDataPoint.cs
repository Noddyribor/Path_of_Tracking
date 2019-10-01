using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    //This class is part of the object returned by poe.ninja api
    public class CurrencyDataPoint
    {
        public int id { get; set; }
        public int league_id { get; set; }
        public int pay_currency_id { get; set; }
        public int get_currency_id { get; set; }
        public string sample_time_utc { get; set; }
        public int count { get; set; }
        public decimal value { get; set; }
        public int data_point_count { get; set; }
        public bool includes_secondary { get; set; }
    }
}
