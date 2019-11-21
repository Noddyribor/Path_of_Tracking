using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    public class Leagues
    {
        public List<string> list { get; set; }

        public bool IsLeagueAvailable(string league)
        {
            foreach(string item in list)
            {
                if(item.Equals(league))
                {
                    return true;
                }
            }
            return false;
        }

        public void setLeagues(List<PoeLeague> list)
        {
            this.list = new List<string>();
            foreach (PoeLeague item in list)
            {
                if (item.id.Contains("SSF")) continue;
                this.list.Add(item.id);
            }
        }

        public List<string> getLeagues()
        {
            return this.list;
        }
    }
}
