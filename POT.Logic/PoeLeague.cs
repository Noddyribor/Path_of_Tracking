using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POT.Logic
{
    public class PoeLeague
    {
        public string id { get; set; }
        public string realm { get; set; }
        public string url { get; set; }
        public DateTime? startAt { get; set; }
        public DateTime? endAt { get; set; }
        public bool? delveEvent { get; set; }

        public PoeLeague()
        {
            this.id = "";
            this.realm = "";
            this.url = "";
            this.startAt = new DateTime();
            this.endAt = new DateTime();
            this.delveEvent = false;
        }
    }
}
