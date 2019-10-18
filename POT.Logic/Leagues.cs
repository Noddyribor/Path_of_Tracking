using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    public class Leagues
    {
        public League[] list { get; set; }

        public bool IsLeagueAvailable(string league)
        {
            foreach(League item in list)
            {
                if(item.id.Equals(league))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
