using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    //This class is part of the object returned by poe.ninja api
    public class CurrencyOverviewLine
    {
        public string currencyTypeName { get; set; }
        public CurrencyDataPoint pay { get; set; }
        public CurrencyDataPoint receive { get; set; }
        public SparkLineInfo paySparkLine { get; set; }
        public SparkLineInfo receiveSparkLine { get; set; }
        public decimal chaosEquivalent { get; set; }
        public SparkLineInfo lowConfidencePaySparkLine { get; set; }
        public SparkLineInfo lowConfidenceReceiveSparkLine { get; set; }
        public string detailsId { get; set; }
    }
}
