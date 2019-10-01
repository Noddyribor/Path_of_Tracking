using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    //This class is part of the object returned by poe.ninja api
    public class SparkLineInfo
    {
        public decimal[] data { get; set; }
        public decimal totalChange { get; set; }
    }
}
